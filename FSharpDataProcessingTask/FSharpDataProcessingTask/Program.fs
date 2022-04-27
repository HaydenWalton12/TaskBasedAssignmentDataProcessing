// Learn more about F# at http://fsharp.org

//Greatly Helped Me During Development - https://dungpa.github.io/fsharp-cheatsheet/

//open - Similar to #using , where it opens a specfic module or namespace where we can then access elements of the namespace without a full reference
//to the name each reference
open System
open System.IO
open System.Linq
open System.Diagnostics
open System.Collections.Generic
//type - used to declare a class , struct , record , basically a location where we store multiple variables , to declare these "variables"
//we use the "member" keyword, 
//member - Use to declare a property or method in object type

type Date( Week : string , Year : string) = 
    member x.Year = Year
    member x.Week = Week

//Order Struct - Similar to the C# Solution , we use class (this case we use a struct) to store all data affliated with order data we are reading to
//write into this type
//Assisted With - https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/fsharp-types
type Order(StoreCode : string , Date : Date , SupplierName : string , SupplierType : string , Cost : double) = 
    member x.StoreCode = StoreCode
    member x.SupplierName = SupplierName
    member x.SupplierType = SupplierType
    member x.Date = Date
    member x.Cost = Cost


//let - Basically as a type of "auto" word that allows us to create variables & functions , we do not specify the decleration
//of functions and variables , we just use let

//Mutable  - THis means that a variable value is prone to change and be updated throughout the program
//Further , variables declared at the top are still considered global variables


let mutable TotalCost = 0.0

//When We Store Query Results - This Mutable Variable Will Increment By One , So When We Store Query We Can Have A New Individual File
//It Doesnt Overide Last Instance And Store Current Query Results In New File (E.G SavedOrders_1.txt , SavedOrders_2.txt)
let mutable FileNameSaveInt = 0

//Directory Variables - Used To Correctly Locate The Project Directories , To Store And Open Files & Folder
//Solution Found From - https://stackoverflow.com/questions/816566/how-do-you-get-the-current-project-directory-from-c-sharp-code-when-creating-a-c

let mutable WorkingDirectory = Environment.CurrentDirectory
let mutable ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName


//Used To Store Directory Paths To Load Order Data
let mutable StoreCodesFile = ""
let mutable DataDirectoryPath = ""

//Used Within SavingQueryData Function To Store The Strings Into List FOr Loading 
let mutable OrderText = ""

//Stores Total Amount Of Loaded Orders
let mutable Orders = List<Order>()

//Stores Total Queried Resuts Based On Search Filters Applied
let mutable QueriedResults = List<Order>()

//Stores All Current Orders Removed From Queried Results
let mutable OrdersRemoved = List<Order>()

//Used For Application Loop , By Default False , If True Application Ends
let mutable QuitApplication = false




//Used To Store Query Options For Filtering Order Data
let mutable StoreQuery = ""
let mutable DateQuery = ""
let mutable SupplierTypeQuery = ""
let mutable SupplierNameQuery = ""

//Stores Menu Choice
let mutable QueryMenuChoice = ""

//Stores Path For File Saving
let mutable FilePath = ""

//Stores Conditions To Access Help Menu
let mutable ViewHelpGuideString = "";
let mutable ViewHelpGuideBool = false;



//With The Given Filtered Queried Results, This Function Allows Us To Store Our Results Into TxT Files
let SaveQueryData() =
    
    Console.WriteLine("Saving Data...")
    
    //Create Local FileName , Use FileNameSaveInt As The Incrementing Factor To Creating New FilePath Each Instance
    //Of Function Execution
    let FileName = "SavedOrder_" + FileNameSaveInt.ToString() + ".txt"
    
    //Increment Perorder Stored In TXT
    let i = 0
 
    let order_for_txt = List<string>()
    
    //For Each Queried Result , Create String Storing Each Order Data , Add To List , List Will Store All Order
    //Strings That Will Be Used To Write Data Into File Path
    for orders in QueriedResults do
        OrderText <- "Order" + i.ToString() + "\nStoreCode : " + orders.StoreCode +
        "\nDate - Week -" + orders.Date.Week.ToString() + " Year - " + orders.Date.Year.ToString() +
        "\nSupplier Type - " + orders.SupplierType.ToString() +
        "\nSupplier Name - " + orders.SupplierName.ToString() +
        "\nCost - " + orders.Cost.ToString()
       
        i = i + 1

        order_for_txt.Add(OrderText) 
        
    //Sets File Path , Will Store Data Into This File Location
    FilePath <-  ProjectDirectory + "\\SavedOrders\\" + FileName
    //Writes Data
    File.WriteAllLines(FilePath , order_for_txt)

    //Opens File Once Data Is Fully Writen For Visual Confirmation Of Data Written Into TXT
    System.Diagnostics.Process.Start("explorer.exe" , FilePath)

    //Solution Found - https://stackoverflow.com/questions/15212133/increment-value-in-f
    FileNameSaveInt <- FileNameSaveInt + 1;

//Gets The Total Sum of QueriedOrders
//Solution Found From - https://stackoverflow.com/questions/824934/the-sum-of-a-specific-property-of-all-items-in-a-list
//Further Assisted By - https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/query-expressions
let GetTotalCost(queriedresults : List<Order>) = 
    
    let orders_sum_cost = queriedresults.ToArray()
    
    let query =
        orders_sum_cost
        |> Seq.sumBy(fun o -> o.Cost)
  
    TotalCost <- query

//Queries Data Based From Entered StoreQuery Choice - 
//The Logic For This Function Applies For Each Other Query Filter Function
let StoreQueryFilter(queriedresults : List<Order>) = 
  
  //This If Will Only Be True, If This Is First Query Filter Applied To An Query Instance ,If Not , We Use Alternate Else If Below
  if queriedresults.Count = 0 then
     for order in Orders do 
            if order.StoreCode = StoreQuery then
               queriedresults.Add(order) 
  //Said Prior , If This Isnt The First Instance Of Query Filtering For Current Instance , We Filter Threw
  //Current Queried Results, We Check For Each Current Queried Order That Doesnt Match Up With Query Parameter Given
  //If Condition True , We Add Current Order To "OrdersRemoved" List
  else if queriedresults.Count > 0 then
      for order in queriedresults do 
          if order.StoreCode <> StoreQuery then
              OrdersRemoved.Add(order) 
  //We Iterate Threw Orders Removed List (Populated Above) , To Remove Each Order From Queried Results, Updating Current Queried Instance
  for order in OrdersRemoved do 
     queriedresults.Remove(order)
let DateQueryFilter(queriedresults : List<Order>) = 
    
    let dateSplit = DateQuery.Split(',')

    if queriedresults.Count = 0 then
        for order in Orders do  
            if order.Date.Week = dateSplit.[0] && order.Date.Year = dateSplit.[1] then
                  queriedresults.Add(order)    

    else if queriedresults.Count > 0 then
        for order in queriedresults do  
            if order.Date.Week <> dateSplit.[0] && order.Date.Year <> dateSplit.[1] then
                OrdersRemoved.Add(order) 

    for order in OrdersRemoved do 
       queriedresults.Remove(order)
let SupplierNameFilter(queriedresults : List<Order>) = 

    if queriedresults.Count = 0 then
        for order in Orders do 
             if order.SupplierName = SupplierNameQuery then
                  queriedresults.Add(order)    

    else if queriedresults.Count > 0 then
        for order in queriedresults do 
            if order.SupplierName <> SupplierNameQuery then
                OrdersRemoved.Add(order) 

    for order in OrdersRemoved do 
       queriedresults.Remove(order)
let SupplierTypeFilter(queriedresults : List<Order>) = 
  
    if queriedresults.Count = 0 then
     for order in Orders do  
             if order.SupplierType = SupplierTypeQuery then
                  queriedresults.Add(order)

    else if queriedresults.Count > 0 then
         for order in Orders do  
                if order.SupplierType <> SupplierTypeQuery then
                OrdersRemoved.Add(order) 

    for order in OrdersRemoved do 
       queriedresults.Remove(order)

//Opens Specficied Location Given Within Directory 
//Solution From - https://stackoverflow.com/questions/1132422/open-a-folder-using-process-start
let OpenSavedOrdersLocation() =
    System.Diagnostics.Process.Start("explorer.exe" , ProjectDirectory + "\SavedOrders")

let OpenOrderInformationLocation() =
    System.Diagnostics.Process.Start("explorer.exe" , ProjectDirectory + "\OrderInformation")


//Help Guide - Self Explanatory 
let HelpGuide() = 
    while ViewHelpGuideBool = true do
        Console.WriteLine("| HELP MENU |")
        Console.WriteLine("How Does It Work - Once All Order Data Has Loaded We Can Process Data.\nVia Entering Integer From 1 - 9 , We Can Execute Command.Commands Type Is Illustrated By Number Accompanied With Text Is Assigned To.\nEnter An Integer , Press Enter To Proceed.\n")
        Console.WriteLine("")
        Console.WriteLine("Exit Guide - Yes/No" )


        ViewHelpGuideString <- Console.ReadLine()
        if ViewHelpGuideString = "Yes" then
           ViewHelpGuideBool <- false
        else if ViewHelpGuideString = "No" then
           ViewHelpGuideBool <- true
        else if ViewHelpGuideString <> "No" || ViewHelpGuideString <> "Yes" then   
            Console.WriteLine("Unknown Command  - Try Again")
            ViewHelpGuideBool <- true

//Main Menu - Proccesses Application And User Response
let QueryMenu() = 
// Print user options
    Console.WriteLine("\n| MAIN MENU |")
    Console.WriteLine("")
    Console.WriteLine("Current Order Queried Statistics :")
    Console.WriteLine("Total Loaded Orders  : " + Convert.ToString(Orders.Count))
    Console.WriteLine("Total Removed Orders : " + Convert.ToString(OrdersRemoved.Count))
    Console.WriteLine("Total Queried Results : " + Convert.ToString(QueriedResults.Count))
    Console.WriteLine("Total Cost Of All Orders : " + Convert.ToString(TotalCost))
    Console.WriteLine("")
    Console.WriteLine("Queried Filters Applied:")
    Console.WriteLine("Store Query : " + StoreQuery)
    Console.WriteLine("Date Query  : " + DateQuery )
    Console.WriteLine("SupplierName Query :" + SupplierNameQuery)
    Console.WriteLine("SupplierType Query :" + SupplierTypeQuery)
    Console.WriteLine("")
    Console.WriteLine("Query Filter Commands :")
    Console.WriteLine("1) Store   \n2.) Date   \n3.) Supplier Name   \n4.) Supplier Type")
    Console.WriteLine("")
    Console.WriteLine("Filtered Result Filter Options :")
    Console.WriteLine("5) Reset Queried Data")
    Console.WriteLine("6) Save Queried Data")
    Console.WriteLine("7) Open Results Folder")
    Console.WriteLine("8) Open Order Information")
    Console.WriteLine("")
    Console.WriteLine("Application Related Options")
    Console.WriteLine("9) Help Guide")
    Console.WriteLine("10) Quit Application")
    Console.WriteLine("")

    //Query Choice Via User Input
    QueryMenuChoice <- Console.ReadLine()

    //Process User Input Accordingly
    if QueryMenuChoice = "1" then
       Console.WriteLine("Enter Store Code To Query With: E.G BIR1")
       StoreQuery <- Console.ReadLine()
       StoreQueryFilter(QueriedResults)
       GetTotalCost(QueriedResults)

    else if QueryMenuChoice = "2" then
       Console.WriteLine("Enter Date Choice To Query With: E.G 12,2013 <- EXACTLY THIS FORMAT")
       DateQuery <- Console.ReadLine()
       DateQueryFilter(QueriedResults)
       GetTotalCost(QueriedResults)

    else if QueryMenuChoice = "3" then
       Console.WriteLine("Enter Supplier Name Choice To Query With: E.G Colgate")
       SupplierNameQuery <- Console.ReadLine()
       SupplierNameFilter(QueriedResults)
       GetTotalCost(QueriedResults)

    else if QueryMenuChoice = "4" then
       Console.WriteLine("Enter Supplier Type Name Choice To Query With: E.G Healthcare")
       SupplierTypeQuery <- Console.ReadLine()
       SupplierTypeFilter(QueriedResults)
       GetTotalCost(QueriedResults)

    //Will Clear The Current Query Instance   
    else if QueryMenuChoice = "5" then
       Console.WriteLine("Are You Sure You Want To Reset Query Options ?")
       let AreYouSure = Console.ReadLine()
       if AreYouSure = "Yes" then
          QueriedResults.Clear()
          OrdersRemoved.Clear()
          SupplierNameQuery <- ""
          SupplierTypeQuery <- ""
          DateQuery  <- ""
          StoreQuery <- ""
          TotalCost <- 0.0
       Console.WriteLine("Query Restarted")

    else if QueryMenuChoice = "6" then
      SaveQueryData()
    
    else if QueryMenuChoice = "7" then
       OpenSavedOrdersLocation()
       Console.WriteLine("")
    
    else if QueryMenuChoice = "8" then
       OpenOrderInformationLocation()
       Console.WriteLine("")
    
    else if QueryMenuChoice = "9" then
       ViewHelpGuideBool <- true
       HelpGuide()
    
    else if QueryMenuChoice = "10" then
        QuitApplication <- true
    
    else if QueryMenuChoice <> "1" || QueryMenuChoice<> "2" || QueryMenuChoice<> "3"  || QueryMenuChoice<> "4"  || QueryMenuChoice<> "5"  || QueryMenuChoice<> "6"  || QueryMenuChoice<> "8"  || QueryMenuChoice<> "9"  || QueryMenuChoice<> "10"then
        Console.WriteLine("Unknown Command Try Again")

//With Given Accumliated "Order Data" , Get And Load The Components That Create The Order "Code , SupplierType/Name & Date" , We
//Use These Components To Query To Find Specfic Data , Here We Get Each Unique Component , Store In A Local List , Then Write Data To TXT File
//This Txt 
let LoadLists() = 
    let supplier_name_dupe = List<string>()
    let supplier_type_dupe = List<string>()
    let date_dupe = List<string>()

    for order in Orders.AsParallel() do
        supplier_name_dupe.Add(order.SupplierName)
        supplier_type_dupe.Add(order.SupplierType)
        date_dupe.Add("Week - " + order.Date.Week + " Year - " + order.Date.Year )
    
    //Using .Distinct , We Can Remove All Duplicated Data ,Creating A Unique List For Each 
    let unique_supplier_name_list = supplier_name_dupe.Distinct().ToList()
    let unqiue_supplier_type_list = supplier_type_dupe.Distinct().ToList()
    let unique_date_list = date_dupe.Distinct().ToList()
    
    //String Array Storing All StoreCode Files - By Reading All Lines From StoreCodeFile
    let store_code = File.ReadAllLines(StoreCodesFile)
    let unique_store_code_list = List<string>()

    //Same Thing We Do Above Except There Is No Duplicate Data
    for storecode in store_code.AsParallel() do
        let store_code_split = storecode.Split(',')
        unique_store_code_list.Add(store_code_split.[0] + " : " + store_code_split.[1])

    //Write Unique List Results Into TXT Files , Allows For Cleaner Searching & Storing Of Unique
    //Data To Assist With Finding Querying Data

    FilePath <-  ProjectDirectory + "\\OrderInformation\\" + "StoreCodeList.txt"     
    File.WriteAllLines(FilePath , unique_store_code_list)

    FilePath <-  ProjectDirectory + "\\OrderInformation\\" + "SupplierNameList.txt"  
    File.WriteAllLines(FilePath , unique_supplier_name_list)

    FilePath <-  ProjectDirectory + "\\OrderInformation\\" + "SupplierTypeList.txt"  
    File.WriteAllLines(FilePath , unqiue_supplier_type_list)

    FilePath <-  ProjectDirectory + "\\OrderInformation\\" + "DateList.txt"  
    File.WriteAllLines(FilePath , unique_date_list)



let main =
    
    //Read Path For StoreCode File Path
    Console.WriteLine("Input Directory That Contains Store Codes")
    StoreCodesFile <- Console.ReadLine()
    Console.WriteLine("")

    //Read Path For Data Location
    Console.WriteLine("Input Directory That Contains Store Data")
    DataDirectoryPath <- Console.ReadLine()

    //FileName Is String Array To Store Directory Files
    let FileNames =  Directory.GetFiles(DataDirectoryPath)
    
    Console.WriteLine("")
    Console.WriteLine("Loading Data...")
    Console.WriteLine("")

    //Load Order System Works Comparatively To The C# Load Data System - That Said We Take The Same Logic & Essentially Translate It
    //For Each File Name In Read File Names , We Read All Lines (Containing The Order Data) From That Current File
    //Instance
    for filename in FileNames do

        //Gets FileName , Removes Directories To Give Just FileName
        let FileNameExt = Path.GetFileName(filename)
        //Removes FileName Extension ".csv"
        let file_name = Path.GetFileNameWithoutExtension(filename)
        //Splits FileName , Containing Data And StoreCode, Used Reference Orders Correctly
        let file_name_split = file_name.Split('_')
        //Reads All Order Data From File from current foreach instance, we then next store this order data in foreach below
        let order_data  = File.ReadAllLines(filename)
    

        //From The Current File Instance , Loads All Order Data , We Then Use This ForEach To Fill In Local Data , This
        //Data Then Gets Added To A List That Stores All Orders From All Files , Store Each Order Using Order
        //Struct 
        for order in order_data do
            let order_split = order.Split(',')
            let store_code  = file_name_split.[0]
            let date = new Date(file_name_split.[1], file_name_split.[2])
            let supplier_name = order_split.[0]
            let supplier_type = order_split.[1]
            let cost = Convert.ToDouble(order_split.[2])
            let new_order = new Order(store_code , date , supplier_name , supplier_type , cost)

            //Adds Current Loaded Order Into Main Order List
            Orders.Add(new_order)
    
    //Generates Order Lists , Lists Will Be Used To Get Unique Order Data For Storing As Reference To What TO Search
    LoadLists()

    Console.WriteLine("All Order Data Has Loaded : Proceed To The Application")

    //Alot Of Data Is Processed Then Stored , GarbageCollector Will Free Up Unused Memory Once Used By Application To Process Data
    //The Only Memory Being Left Being Consumed Will Be "Order" Data. An Example Of Data That Will Be Cleared Is The Dupe Data From
    //Load Lists Function , Since The Data Is Local And Is No Longer Needed, That Data Memory Used To Store Local Data Is Freed
    GC.Collect()

    //Application Loop
    while QuitApplication = false do
        QueryMenu()
    Console.WriteLine("Goodbye :)")
    

// Learn more about F# at http://fsharp.org

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

//Stores Total Amount Of Loaded Orders
let mutable Orders = List<Order>()

//Used For Application Loop , By Default False , If True Application Ends
let mutable QuitApplication = false

let mutable OrdersInTxt = List<string>()

let mutable OrderData = [|"" ; ""|]

let mutable text = ""
let mutable SupplierName = ""


let mutable StoreQuery = ""
let mutable DateQuery = ""
let mutable SupplierTypeQuery = ""
let mutable SupplierNameQuery = ""
let mutable QueryMenuChoice = ""
let mutable FilePath = ""
let mutable ViewHelpGuideString = "";
let mutable ViewHelpGuideBool = false;
let mutable QueriedResults = List<Order>()
let mutable OrdersRemoved = List<Order>()



let SaveQueryData() =
    Console.WriteLine("Saving Data")

    let FileName = "SavedOrder_" + FileNameSaveInt.ToString() + ".txt"
    Console.WriteLine("Saving Data")
    let i = 0
    let OrderContents = [|"" ; ""|]

    for orders in QueriedResults do
        text <- "Order" + i.ToString() + "\nStoreCode : " + orders.StoreCode +
        "\nDate - Week -" + orders.Date.Week.ToString() + " Year - " + orders.Date.Year.ToString() +
        "\nSupplier Type - " + orders.SupplierType.ToString() +
        "\nSupplier Name - " + orders.SupplierName.ToString() +
        "\nCost - " + orders.Cost.ToString()
        
        OrdersInTxt.Add(text)
        
    FilePath <-  ProjectDirectory + "\\SavedOrders\\" + FileName  
    
    let OrderInTxtArray = OrdersInTxt.ToArray()
    File.WriteAllLines(FilePath , OrderInTxtArray)
    System.Diagnostics.Process.Start("explorer.exe" , FilePath)
    FileNameSaveInt <- + 1;

let GetTotalCost(queriedresults : List<Order>) = 
    let CostOrder = queriedresults.ToArray()
    
    let query =
        CostOrder
        |> Seq.sumBy(fun o -> o.Cost)
  
    TotalCost <- query

let StoreQueryFilter(queriedresults : List<Order>) = 
  
  if queriedresults.Count = 0 then
     for order in Orders do 
            if order.StoreCode = StoreQuery then
               queriedresults.Add(order) 

  else if queriedresults.Count > 0 then
      for order in queriedresults do 
          if order.StoreCode <> StoreQuery then
              OrdersRemoved.Add(order) 

  for order in OrdersRemoved do 
     queriedresults.Remove(order)

let OpenSavedOrdersLocation() =
    System.Diagnostics.Process.Start("explorer.exe" , ProjectDirectory + "\SavedOrders")

let OpenOrderInformationLocation() =
    System.Diagnostics.Process.Start("explorer.exe" , ProjectDirectory + "\OrderInformation")

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




let HelpGuide() = 
    if ViewHelpGuideBool = true then
        Console.WriteLine("| HELP MENU |")
        Console.WriteLine("How Does It Work - Once All Order Data Has Loaded We Can Process Data.\nVia Entering Integer From 1 - 9 , We Can Execute Command.Commands Type Is Illustrated By Number Accompanied With Text Is Assigned To.\nEnter An Integer , Press Enter To Proceed.\n")
        Console.WriteLine("")
        Console.WriteLine("Exit Guide - Yes/No" )


        ViewHelpGuideString <- Console.ReadLine()
        if ViewHelpGuideString = "Yes" then
           ViewHelpGuideBool <- false
        else if ViewHelpGuideString = "No" then
           ViewHelpGuideBool <- true

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
    QueryMenuChoice <- Console.ReadLine()

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

let LoadLists() = 


    let supplier_name_dupe = List<string>()
    let supplier_type_dupe = List<string>()
    let date_dupe = List<string>()

    for order in Orders.AsParallel() do
        supplier_name_dupe.Add(order.SupplierName)
        supplier_type_dupe.Add(order.SupplierType)
        date_dupe.Add("Week - " + order.Date.Week + " Year - " + order.Date.Year )
    
    let unique_supplier_name_list = supplier_name_dupe.Distinct().ToList()
    let unqiue_supplier_type_list = supplier_type_dupe.Distinct().ToList()
    let unique_date_list = date_dupe.Distinct().ToList()
    
    let store_code = File.ReadAllLines(StoreCodesFile)
    let unique_store_code_list = List<string>()

    for storecode in store_code.AsParallel() do
        let store_code_split = storecode.Split(',')
        unique_store_code_list.Add(store_code_split.[0] + " : " + store_code_split.[1])

    //Write Unique List Results Into TXT Files , Allows For Cleaner Searching & Storing Of Unique
    //Data To Assist With Querying
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
    //
    for filename in FileNames do

        let FileNameExt = Path.GetFileName(filename)
        let FileName = Path.GetFileNameWithoutExtension(filename)
        let FileNameSplit = FileName.Split('_')
        let OrderData  = File.ReadAllLines(filename)
     
        for orderdata in OrderData do
            let order_split = orderdata.Split(',')
            let store_code  = FileNameSplit.[0]
            let date = new Date(FileNameSplit.[1], FileNameSplit.[2])
            let supplier_name = order_split.[0]
            let supplier_type = order_split.[1]
            let cost = Convert.ToDouble(order_split.[2])
            let order = new Order(store_code , date , supplier_name , supplier_type , cost)
            Orders.Add(order)
    
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
    







//QUERY DATA - https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/query-expressions



// Learn more about F# at http://fsharp.org

//open - Similar to #using , where it opens a specfic module or namespace where we can then access elements of the namespace without a full reference
//to the name each reference
open System
open System.IO
open System.Linq
open System.Diagnostics
open System.Threading.Tasks

open System.Collections.Generic
open System.Collections.Concurrent
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

let mutable WorkingDirectory = Environment.CurrentDirectory
let mutable ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName
let mutable FileNameSaveInt = 0
let mutable DataDirectoryPath = ""
let mutable OrdersInTxt = List<string>()
let mutable StoreCodesFile = ""
let mutable Orders = List<Order>()
let mutable FileNameExt = ""
let mutable FileName = ""
let mutable FileNameSplit = [|"" ; ""|]
let mutable OrderSplit = [|"" ; ""|]
let mutable OrderData = [|"" ; ""|]
let mutable date = Date("" , "")
let mutable text = ""
let mutable SupplierName = ""
let mutable StoreCode = ""
let mutable SupplierType = ""
let mutable Cost = 0.0
let mutable Order = new Order("" , date , "" , " " , 0.0)
let mutable QuitApplication = false

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

let OlderFolderLocation() =
    System.Diagnostics.Process.Start("explorer.exe" , ProjectDirectory + "\SavedOrders")

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
    Console.WriteLine("")
    Console.WriteLine("Application Related Options")
    Console.WriteLine("8) Help Guide")
    Console.WriteLine("9) Quit Application")
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
       OlderFolderLocation()
       Console.WriteLine("")
       ViewHelpGuideBool <- true
       HelpGuide()
    else if QueryMenuChoice = "8" then
       ViewHelpGuideBool <- true
       HelpGuide()
    else if QueryMenuChoice = "9" then
        QuitApplication <- true

let main =
    
    Console.WriteLine("Input Directory That Contains Store Codes")
    StoreCodesFile <- Console.ReadLine()

    Console.WriteLine("Input Directory That Contains Store Data")
    DataDirectoryPath <- Console.ReadLine()

    //FileName Is String List , To Store Directory Files , We Convert ToArray
    let FileNames =  Directory.GetFiles(DataDirectoryPath)

    Console.WriteLine("Loading Data")

    //Declare New StopWatch Variable To Track Time
    let stopwatch : Stopwatch = new Stopwatch()
    
    //Start StopWatch
    stopwatch.Start()
    
    for filename in FileNames do
        FileNameExt   <- Path.GetFileName(filename)
        FileName      <- Path.GetFileNameWithoutExtension(filename)
        FileNameSplit <- FileName.Split('_')
        OrderData     <- File.ReadAllLines(filename)
     
        for orderdata in OrderData do
            OrderSplit <- orderdata.Split(',')
            StoreCode  <- FileNameSplit.[0]
            date <- new Date(FileNameSplit.[1], FileNameSplit.[2])
            SupplierName <- OrderSplit.[0]
            SupplierType <- OrderSplit.[1]
            Cost <- Convert.ToDouble(OrderSplit.[2])
            Order <- new Order(StoreCode , date , SupplierName , SupplierType , Cost)
            Orders.Add(Order)
    stopwatch.Stop()

    Console.WriteLine("Finished Loading " + Convert.ToString(Orders.Count) + " files in " + Convert.ToString(Convert.ToDouble(stopwatch.ElapsedMilliseconds)/1000.0) + " seconds." + "\n")
    
    while QuitApplication = false do
        QueryMenu()
    Console.WriteLine("Goodbye :)")
    







//QUERY DATA - https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/query-expressions



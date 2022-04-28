      //Old Attempt Of Creating Query Load Function , This Was Created In Purpose Of Refactoring The Code To Generate The ListViewFields Quicker Since Depending On The
       //Queried Results, THe Time TO Populate Can Take  A While , This Said I decided To split up the ListFields into two , split the query data into two chunks
       //then populate each field parralel using TPL, this had mixed results with a few minor errors, once eventually resolving it and timing it , It performed around the same
       //time as the current function in place, so I removed it in favour for cleaner code , I find this design to be overengineered 
/*
        foreach (var item in items1)
                    {OrderSearchResultsListView.Items.Add(item);}
                    
        foreach (var item in items2)
                    {OrderserchResultsListView2.Items.Add(item);}
    
        int orderquarter = Ordersize / 4;
       
        int k = 1;
        int j = 2;
        int f = 3;
        
        for (int i = 0; i < orderquarter; i++)
        {
            OrderSearchResultsListView.Items.Add(items1[i]);
            if (i < orderhalfsize - 1)
            {
                OrderserchResultsListView2.Items.Add(items2[i]);
            }

            OrderSearchResultsListView.Items.Add(items1[i]);
            OrderSearchResultsListView.Items.Add(items1[k]);
            OrderSearchResultsListView.Items.Add(items1[j]);
            OrderSearchResultsListView.Items.Add(items1[f]);

            if (k < items2.Count || i < items2.Count - 1)
            {
                OrderserchResultsListView2.Items.Add(items2[i]);
                OrderSearchResultsListView.Items.Add(items2[k]);
            }

            i = i + 3;
            k = k + 4;
            j = j + 4;
            f = f + 4;

        }

        Task task3 = new Task(() => { LoadList1(items1); });
        Task task4 = new Task(() => { LoadList2(items2); });

        task3.Start();
        task4.Start();

        task4.Wait();

        foreach (var order in Orders)
        {
            string[] subitem = new string[5];

            subitem[0] = order.StoreCode;
            subitem[1] = order.SupplierName;
            subitem[2] = order.SupplierType;
            subitem[3] = order.Date.Week.ToString() + " , " + order.Date.Year.ToString();
            subitem[4] = "£ " + order.Cost.ToString();

            ListViewItem item = new ListViewItem(subitem);

            OrderSearchResultsListView.Items.Add(item);
        }



        foreach (var item in orderchunk1)
        {
            if (item != null){ OrderSearchResultsListView.Items.Add(item[0]);}
        }
        foreach (var item in orderchunk2)
        {
            if (item != null) {OrderserchResultsListView2.Items.Add(item[0]);}
        }
*/
    
    //These Are The two functions that accompany the code above (seen being executed as functions for TPL tasks) , these functions are what populate the ListView Lists
    //With populated items to add to the lists
/*
    private void LoadList1(List<ListViewItem> data)
    {
        foreach (var item in data)
        {
            Invoke(new Action(() =>
         {
             OrderSearchResultsListView.Items.Add(item);
         }));
        }


    }

    private void LoadList2(List<ListViewItem> data)
    {
        foreach (var item in data)
        {
            Invoke(new Action(() =>
            {
                OrderserchResultsListView2.Items.Add(item);
            }));
        }


    }
*/
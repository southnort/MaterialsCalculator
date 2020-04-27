using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Globalization;
using System.Collections.Specialized;
using System.Net.Http;
using MaterialsCalculatorDirty.Classes;
using Newtonsoft.Json;
using System.Json;
using ClosedXML.Excel;



namespace MaterialsCalculatorDirty
{
    public class TestProgram
    {
        private string contactsFileName = "contacts.json";
        private string leadsFileName = "leads.json";
        private string contactsExcelFileName = "Contacts.xlsx";

        

        public void Run()
        {
            List<Contact> contacts = new List<Contact>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + contactsExcelFileName;

            var workBook = new XLWorkbook(path);
            var ws1 = workBook.Worksheet(1);

            foreach (var row in ws1.Rows())
            {                
                if (row.Cell(0).GetValue<string>() != "Тип")
                {
                    Contact contact = new Contact();

                    contact.name = row.Cell(1).GetValue<string>();
                    contact.creatingDate = row.Cell(2).GetValue<DateTime>();
                }
            }
        }





        //public void Run()
        //{
        //    List<Contact> contacts = new List<Contact>();
        //    List<Lead> leads = new List<Lead>();


        //   var contactsFilePath =Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory)+"\\"+contactsFileName;
        //    var leadsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + leadsFileName;

        //    using (StreamReader sr = new StreamReader(contactsFilePath))
        //    {
        //        string json = sr.ReadToEnd();
        //        dynamic array = JsonConvert.DeserializeObject(json);

        //        foreach (var item in array._embedded.items)
        //        {
        //            var contact = new Contact();

        //            contact.id = ParseDynamic(item.id);
        //            contact.name = item.name;
        //            contact.resposible_user_id = ParseDynamic(item.resposible_user_id);
        //            contact.created_by = ParseDynamic(item.created_by);
        //            contact.created_at = ParseDynamic(item.created_at);
        //            contact.updated_at = ParseDynamic(item.updated_at);
        //            contact.account_id = ParseDynamic(item.account_id);
        //            contact.updated_by = ParseDynamic(item.updated_by);
        //            contact.group_id = ParseDynamic(item.group_id);
        //            contact.closest_task_at = ParseDynamic(item.closest_task_at);

        //            contacts.Add(contact);

        //        }
        //        Console.WriteLine(array._embedded.items.Count.ToString());
        //        Console.WriteLine(contacts.Count);
        //    }

            
            

        //}


        //private int ParseDynamic(dynamic ob)
        //{
        //    if (ob == null)
        //        return 0;
        //    return ob;
        //}

    }
}

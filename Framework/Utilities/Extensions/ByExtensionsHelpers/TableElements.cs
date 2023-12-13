using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Star.Web.AutomatedUITests.Framework.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star.Web.AutomatedUITests.Framework.Utilities.Helpers;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers
{
    public static class TableElements
    {
        /// <summary>
        /// Waits for the table webElement using the given By. Returns the row at index nRow
        /// NOTE: This is zero referenced (although for some tables, row 0 is the headings)
        /// </summary>
        /// <param name="elementLocator">Used to locate the table element, e.g. By.Id("xyz")</param>
        /// <param name="nRow">Index of the row to return</param>
        /// <param name="waitSeconds">Time to wait before timeout</param>
        /// <returns>IWebElement</returns>
        public static IWebElement GetTableNthRow(this By elementLocator, int nRow, TimeSpan? customTimeout = null)
        {
            var wait = SeleniumExecutor.WaitDriver(customTimeout);
            List<IWebElement> rows = new List<IWebElement>();

            var tableElement = GetElements.GetVisibleElement(elementLocator, customTimeout);

            //Check we have returned a table
            Assert.IsNotNull(tableElement, $"Did not find the table given by: {elementLocator}");
            Assert.AreEqual("table", tableElement.TagName, $"Element given by: {elementLocator} is not a table!");

           
            //Waits for the required minimum number of rows
            if (wait.Until(x => tableElement.FindElements(By.TagName("tr")).Count >= nRow))
            {
                rows = tableElement.FindElements(By.TagName("tr")).ToList();
                Assert.IsNotNull(rows.ElementAt(nRow), $"Did not find any data a row index: {nRow}");
            }

            return rows[nRow];
        }


        /// <summary>
        /// Returns a list of columns for the given webElementRow.
        /// Could be used in tandem with GetTableNthRow() 
        /// </summary>
        /// <param name="webElementRow">The row from which you want to get columns</param>
        /// <returns>Collection of IWebElements</returns>
        public static ReadOnlyCollection<IWebElement> GetRowAllColumns(IWebElement webElementRow)
        {
            Assert.IsTrue(webElementRow.TagName == "tr", "Element is not a row!");
            return webElementRow.FindElements(By.TagName("td"));
        }

        /// <summary>
        /// Returns the column for the given webElementRow and nColumn index.
        /// NOTE: This is zero referenced 
        /// Could be used in tandem with GetTableRow() 
        /// </summary>
        /// <param name="webElementRow">The row from which you want to get columns</param>
        /// <param name="nColumn">Index of the column to return</param>
        /// <returns>IWebElement</returns>
        public static IWebElement GetRowNthColumn(IWebElement webElementRow, int nColumn)
        {
            Assert.IsTrue(webElementRow.TagName == "tr", "Element is not a row!");
            var columnList = webElementRow.FindElements(By.TagName("td"));

            return columnList[nColumn];
        }


        /// <summary>
        /// Looks for table webElement using the given By.
        /// Returns list of rows that contains the specified text
        /// </summary>
        /// <param name="elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="textToBeFound">text that you want to row to contain</param>
        /// <returns>Collection of IWebElements</returns>
        public static IEnumerable<IWebElement> GetTableRowsContainingValue(By elementLocator, string textToBeFound, int nRow=1, TimeSpan? customTimeout = null)
        {
            var wait = SeleniumExecutor.WaitDriver(customTimeout);
            var tableElement = GetElements.GetVisibleElement(elementLocator);
            Assert.IsNotNull(tableElement, $"Didn't find the table given by: {elementLocator}");
            Assert.IsTrue(tableElement.TagName == "table", "Element is not a table!");
            List<IWebElement> rows = new List<IWebElement>();

            //Waits for the required minimum number of rows
            if (wait.Until(x => tableElement.FindElements(By.TagName("tr")).Count >= nRow))
            {
                rows = tableElement.FindElements(By.TagName("tr")).ToList();
                Assert.IsNotNull(rows.ElementAt(nRow), $"Did not find any data a row index: {nRow}");
            }

            return tableElement.FindElements(By.TagName("tr")).Where(row => row.Text.Contains(textToBeFound));
        }


        /// <summary>
        /// Looks for table webElement using the given By. Then waits for the given row and column combination
        /// to contain the specified text
        /// </summary>
        /// <param name="table">table row is in</param>
        /// <param name="rowNo">row in table</param>
        /// <param name="columnNo">column in row to contain the text</param>
        /// <param name="searchText">text the table, row, column combintation needs to be </param>
        /// <returns></returns>
        public static IWebElement WaitForNthColOfNthRowToContainText(By table, int rowNo, int columnNo, string searchText)
        {
            IWebElement row = null;

            for (int i = 0; i < 100; i++)
            {
                row = TableElements.GetTableNthRow(table, rowNo);

                if (TableElements.GetRowNthColumn(row, columnNo).Text == searchText)
                    break;

                Thread.Sleep(100);
            }

            //If not working, give it another try.
            if (TableElements.GetRowNthColumn(row, columnNo).Text != searchText)
            {
                for (int i = 0; i < 100; i++)
                {
                    row = TableElements.GetTableNthRow(table, rowNo);

                    if (TableElements.GetRowNthColumn(row, columnNo).Text == searchText)
                        break;

                    Thread.Sleep(100);
                }
            }

            return row;
        }


        /// <summary>
        /// Returns list of columns that contains the specified text
        /// Could be used in tandem with GetTableNthRow() 
        /// </summary>
        /// <param name="webElementRow">The row from which you want to get columns</param>
        ///  /// <param name="textToBeFound">text that you want to column to contain</param>
        /// <returns>Collection of IWebElements</returns>
        public static IEnumerable<IWebElement> GetRowAllColumnsContainingText(IWebElement webElementRow, string textToBeFound)
        {
            Assert.IsTrue(webElementRow.TagName == "tr", "Element is not a row!");
            return webElementRow.FindElements(By.TagName("td")).Where(col => col.Text.Contains(textToBeFound));
        }

        /// <summary>
        /// Returns first column that contains the specified text
        /// Could be used in tandem with GetTableNthRow() 
        /// </summary>
        /// <param name="webElementRow">The row from which you want to get columns</param>
        ///  /// <param name="textToBeFound">text that you want to column to contain</param>
        /// <returns>Collection of IWebElements</returns>
        public static IWebElement GetRowFirstColumnContainingText(IWebElement webElementRow, string textToBeFound)
        {
            Assert.IsTrue(webElementRow.TagName == "tr", "Element is not a row!");
            return webElementRow.FindElements(By.TagName("td")).Where(col => col.Text.Contains(textToBeFound)).First();
        }

    }
}

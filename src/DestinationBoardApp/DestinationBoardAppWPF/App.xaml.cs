using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DestinationBoardAppWPF
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        //SQLiteのファイルはユーザローカルに保存する
        private static readonly string databaseName = "DestinationBoard.db";
        private static readonly string databaseFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string DatabasePath = System.IO.Path.Combine(databaseFolderPath, databaseName);
    }
}

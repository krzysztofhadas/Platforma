using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platforma.PolaczenieZBazą
{
    class SQLHelper
    {

        public static string connectionString = Properties.Settings.Default.CString;


        public static bool dodajSort(string prefiks, string numer, string linia, string data, string opis, string inzynier, string firma)
        {
            try
            {
                using (var polaczenie = new SqlConnection(connectionString))
                {
                    using (var komenda = polaczenie.CreateCommand())
                    {
                        komenda.CommandText = $"insert into dbo.ListaSortow(prefix, numerCzesci, linia, dataUruchomienia, firmaDostawca, inzynier, opisProblemu, status) values ('{prefiks}', '{numer}', '{linia}', '{data}', '{firma}', '{inzynier}', '{opis}', 'Tak')";
                        polaczenie.Open();
                        komenda.ExecuteNonQuery();
                        SqlDataAdapter SqlDataAdap = new SqlDataAdapter(komenda);
                        polaczenie.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        public static void usunSort(string prefiks)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($" DELETE FROM dbo.ListaSortow WHERE prefix = '{prefiks}'", cnn))
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    cnn.Close(); 
                }
            }
        }

        public static bool dodajWpisDoSortu(string prefix, string data, string numerCzesci, int iloscSprawdzonych, int iloscOK, int iloscNok)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand($"insert into dbo.SzczegolySortowania(prefix, data, numerCzesci, iloscSprawdzonych, iloscOk, IloscNok) values ('{prefix}', '{data}', '{numerCzesci}', {iloscSprawdzonych}, {iloscOK}, {iloscNok})", cnn))
                    {
                        cnn.Open();
                        command.ExecuteNonQuery();
                        SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                        cnn.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            
        }

        public static bool aktualizujWadeSortu(string staraWada, string numerCzesci, string nowaWada)
        {
            using (var polaczenie = new SqlConnection(connectionString))
            {
                using (var komenda = polaczenie.CreateCommand())
                {
                    komenda.CommandText = $"update dbo.ListaSortow set opisProblemu = '{nowaWada}' where numerCzesci = '{numerCzesci}' and opisProblemu = '{staraWada}'";
                    polaczenie.Open();
                    komenda.ExecuteNonQuery();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(komenda);
                    polaczenie.Close();
                    return true;
                }
            }
        }

        public static DataTable pobierzListeSortow(string status)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"select * from [dbo].[ListaSortow] where status = '{status}' order by id", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    cnn.Close();
                    return dtWynik;
                }
            }
        }

        public static DataTable pobierzListeRaportow()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"select * from [dbo].[raporty]", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    cnn.Close();
                    return dtWynik;
                }
            }
        }

        
        public static DataTable pobierzListeWpisow(string prefiks, string numerCzesci)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"select * from [dbo].[SzczegolySortowania] where prefix = '{prefiks}' and numerCzesci = '{numerCzesci}' order by data", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    cnn.Close();
                    return dtWynik;
                }
            }
        }

        public static bool usunWpis(string prefiks, string data)
        {  
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"delete from dbo.SzczegolySortowania where data = '{data}' and prefix = '{prefiks}'", cnn))
                { 
                    cnn.Open();
                    command.ExecuteNonQuery();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    cnn.Close();
                    return true;
                }
            }
        }

        internal static bool zakonczSort(string prefiks, string numerCzesci, string status, string dataRozpoczecia, string inzynier, string wady)
        {
            DateTime today = DateTime.Today;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            { 
                if(status == "Nie")
                {
                    using (SqlCommand command = new SqlCommand($"UPDATE dbo.ListaSortow SET status = '{status}' where prefix = '{prefiks}' and numerCzesci = '{numerCzesci}';" +
                                                           $"insert into [dbo].[raporty](identyfikatorSortu, numerCzesci, dataUruchomienia, dataZakonczenia, inzynier, wady) values ('{prefiks}','{numerCzesci}','{dataRozpoczecia}', '{today.ToString("dd-MM-yyyy")}', '{inzynier}', '{wady}')", cnn))
                    {
                        cnn.Open();
                        command.ExecuteNonQuery();
                        SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                        cnn.Close();
                        return true;
                    }
                }
                else
                {
                    using (SqlCommand command = new SqlCommand($"UPDATE dbo.ListaSortow SET status = '{status}' where prefix = '{prefiks}' and numerCzesci = '{numerCzesci}';" +
                                                           $"delete from dbo.raporty where identyfikatorSortu = '{prefiks}'", cnn))
                    {
                        cnn.Open();
                        command.ExecuteNonQuery();
                        SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                        cnn.Close();
                        return true;
                    }
                }
                
            }
        }

        public static DataTable sumaWszystkichCzesci(string prefiks, string numerCzesci)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"select sum(iloscSprawdzonych) from [dbo].[SzczegolySortowania] where prefix = '{prefiks}' and numerCzesci = '{numerCzesci}'", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    cnn.Close();
                    return dtWynik;
                }
            }
        }

        public static DataTable sumaWszystkichDobrychCzesci(string prefiks, string numerCzesci)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"select sum(iloscOk) from [dbo].[SzczegolySortowania] where prefix = '{prefiks}' and numerCzesci = '{numerCzesci}'", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    cnn.Close();
                    return dtWynik;
                }
            }
        }

        public static DataTable sumaWszystkichWadliwychCzesci(string prefiks, string numerCzesci)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"select sum(iloscNok) from [dbo].[SzczegolySortowania] where prefix = '{prefiks}' and numerCzesci = '{numerCzesci}'", cnn))
                {
                    cnn.Open();
                    SqlDataAdapter SqlDataAdap = new SqlDataAdapter(command);
                    DataTable dtWynik = new DataTable();
                    SqlDataAdap.Fill(dtWynik);
                    cnn.Close();
                    return dtWynik;
                }
            }
        }
    }
}

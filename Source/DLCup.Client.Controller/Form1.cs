using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DLCup.Client.Controller;

namespace DLCupController
{
    public partial class frmMain : Form
    {
        private string _connectionString;

        public frmMain()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["DLCup"].ConnectionString;

            cboMatch.DisplayMember = "Value";
            cboSet.DisplayMember = "Value";
        }

        private void btnAddHomeScore_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("HomeScoreAdd");
        }

        private void ExecuteProcedure(string spName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    SqlCommand command = con.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;

                    SqlParameter matchParam = command.Parameters.Add("@MatchId", SqlDbType.Int, sizeof(System.Int32));
                    SqlParameter gameParam = command.Parameters.Add("@GameId", SqlDbType.Int, sizeof(System.Int32));
                    matchParam.Value = ((DictionaryEntry)cboMatch.SelectedItem).Key;
                    gameParam.Value = ((DictionaryEntry)cboSet.SelectedItem).Key;

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddGuestScore_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("GuestScoreAdd");
        }

        private void btnSubtractHomeScore_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("HomeScoreSubtract");
        }

        private void btnSubtractGuestScore_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("GuestScoreSubtract");
        }

        private void btnResetSet_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("ClearSet");
        }

        private void btnRemoveSet_Click(object sender, EventArgs e)
        {
            ExecuteProcedure("RemoveSet");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadMatches();
        }

        private void LoadMatches()
        {
            try
            {
                var cupId = AppSettingsHelper.GetValue("CupId", 1);

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    SqlCommand matchQ = con.CreateCommand();
                    SqlCommand gameQ = con.CreateCommand();

                    matchQ.CommandType = CommandType.Text;
                    matchQ.CommandText = @"select MatchId, MatchType + ' (' + cast(Points as varchar(10)) + 'p)' from Match where CupId = @CupId order by PlayOrder asc";
                    matchQ.Parameters.Add("@CupId", SqlDbType.Int).Value = cupId;

                    SqlDataReader matchR = matchQ.ExecuteReader();
                    cboMatch.Items.Clear();
                    if (matchR != null)
                    {
                        while (matchR.Read())
                        {
                            DictionaryEntry de = new DictionaryEntry();
                            de.Key = matchR[0];
                            de.Value = matchR[1];
                            cboMatch.Items.Add(de);
                        }
                    }

                    if (cboMatch.Items.Count > 0)
                    {
                        cboMatch.SelectedIndex = 0;
                        LoadSets();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadSets()
        {
            try
            {
                DictionaryEntry matchDe = (DictionaryEntry)cboMatch.SelectedItem;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    SqlCommand gameQ = con.CreateCommand();

                    gameQ.CommandType = CommandType.Text;
                    gameQ.CommandText = string.Format("select GameId from Game where MatchId = {0} order by GameId asc", matchDe.Key);

                    SqlDataReader gameR = gameQ.ExecuteReader();
                    cboSet.Items.Clear();
                    if (gameR != null)
                    {
                        int setNumber = 1;
                        while (gameR.Read())
                        {
                            DictionaryEntry de = new DictionaryEntry();
                            de.Key = gameR[0];
                            de.Value = setNumber++;
                            cboSet.Items.Add(de);
                        }
                    }

                    if (cboSet.Items.Count > 0)
                    {
                        cboSet.SelectedIndex = 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSets();
        }
    }
}

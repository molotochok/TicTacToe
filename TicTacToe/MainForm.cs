using System;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Interface MainForm which consists of methods that are useful in Presenter
    /// </summary>
    interface IMainForm
    {
        // Menu 
        Panel PanelMenu { get; set; }

        GroupBox GroupBoxOpponent   { get; set; }
        GroupBox GroupBoxDifficulty { get; set; }
        GroupBox GroupBoxChoose     { get; set; }

        Button BtnChooseX { get; set; }
        Button BtnChooseO { get; set; }

        ComboBox ComboBoxOpponent   { get; set; }
        ComboBox ComboBoxDifficulty { get; set; }

        event EventHandler ComboBoxOpponentChanged;
        event EventHandler BtnConfirmClicked;
        event EventHandler BtnClicked;
        event EventHandler BtnChooseXClicked;
        event EventHandler BtnChooseOClicked;

        // Game
        Panel PanelGame { get; set; }
        Label LabelTurn { get; set; }

        Button[,] BtnsTicTacToe { get; set; }

        Button BtnBack    { get; set; }
        Button BtnRefresh { get; set; }

        event EventHandler BtnBackClicked;
        event EventHandler BtnRefreshClicked;

        // Used to make changes with UI elements in different threads
        void ExecuteDelegateOnUIThread(Delegate del);
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            btnConfirm.Click += BtnConfirm_Click;
            btnChooseX.Click += BtnChooseX_Click;
            btnChooseO.Click += BtnChooseO_Click;

            btn00.Click += Btn_Click;
            btn01.Click += Btn_Click;
            btn02.Click += Btn_Click;
            btn10.Click += Btn_Click;
            btn11.Click += Btn_Click;
            btn12.Click += Btn_Click;
            btn20.Click += Btn_Click;
            btn21.Click += Btn_Click;
            btn22.Click += Btn_Click;

            btnBack.Click += BtnBack_Click;
            btnRefresh.Click += BtnRefresh_Click;

            ComboBoxOpponent.SelectedIndexChanged += ComboBoxOpponent_SelectedIndexChanged;
        }

        // Callback methods
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnRefreshClicked.Invoke(sender, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BtnBackClicked.Invoke(sender, e);
        }

        private void BtnChooseO_Click(object sender, EventArgs e)
        {
            BtnChooseOClicked.Invoke(sender, e);
        }

        private void BtnChooseX_Click(object sender, EventArgs e)
        {
            BtnChooseXClicked.Invoke(sender, e);
        }

        private void ComboBoxOpponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxOpponentChanged.Invoke(sender, e);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            BtnClicked.Invoke(sender, e);
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            BtnConfirmClicked.Invoke(sender, e);
        }

        #region IMainForm
        // Menu 
        public Label LabelTurn { get => labelTurn; set => labelTurn = value; }

        public Panel PanelMenu { get => panelMenu; set => panelMenu = value; }
        public Panel PanelGame { get => panelGame; set => panelGame = value; }

        public GroupBox GroupBoxOpponent   { get => groupBoxOpponent;   set => groupBoxOpponent = value; }
        public GroupBox GroupBoxDifficulty { get => groupBoxDifficulty; set => groupBoxOpponent = value; }
        public GroupBox GroupBoxChoose     { get => groupBoxChoose;     set => groupBoxChoose = value; }

        public Button BtnChooseX { get => btnChooseX; set => btnChooseX = value; }
        public Button BtnChooseO { get => btnChooseO; set => btnChooseO = value; }

        public ComboBox ComboBoxOpponent   { get => comboBoxOpponent; set => comboBoxOpponent = value; }
        public ComboBox ComboBoxDifficulty { get => comboBoxDifficulty; set => comboBoxDifficulty = value; }

        public Button BtnConfirm { get => btnConfirm; set => btnConfirm = value; }

        public event EventHandler ComboBoxOpponentChanged;
        public event EventHandler BtnConfirmClicked;
        public event EventHandler BtnClicked;
        public event EventHandler BtnChooseXClicked;
        public event EventHandler BtnChooseOClicked; 
        // Game 
        public Button[,] BtnsTicTacToe {
            get 
            {
                Button[,] btns = new Button[3, 3];
                btns[0, 0] = btn00;
                btns[0, 1] = btn01;
                btns[0, 2] = btn02;
                btns[1, 0] = btn10;
                btns[1, 1] = btn11;
                btns[1, 2] = btn12;
                btns[2, 0] = btn20;
                btns[2, 1] = btn21;
                btns[2, 2] = btn22;

                return btns;
            }
            set 
            {
                Button[,] btns = value;
                btn00 = btns[0, 0];
                btn01 = btns[0, 1];
                btn02 = btns[0, 2];
                btn10 = btns[1, 0];
                btn11 = btns[1, 1];
                btn12 = btns[1, 2];
                btn20 = btns[2, 0];
                btn21 = btns[2, 1];
                btn22 = btns[2, 2];
            }
        }
        public Button BtnBack    { get => btnBack;  set => btnBack = value; }
        public Button BtnRefresh { get => btnRefresh; set => btnRefresh = value; }

        public event EventHandler BtnBackClicked;
        public event EventHandler BtnRefreshClicked;

        // Used to make changes with UI elements in different threads
        public void ExecuteDelegateOnUIThread(Delegate action)
        {
            Invoke(action);
        }
        #endregion


    }
}

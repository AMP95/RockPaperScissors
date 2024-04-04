using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RockPaperScissors
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        RPS _playerChoice;
        RPS _machineChoice;
        string _winner;
        void Notify(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public RPS PlayerChoice
        {
            get { return _playerChoice; }
            set {
                _playerChoice = value;
                Notify("PlayerChoice");
            }
        }
        public RPS MachineChoice
        {
            get { return _machineChoice; }
            set
            {
                _machineChoice = value;
                Notify("MachineChoice");
            }
        }
        public string Winner
        {
            get { return _winner; }
            set {
                _winner = value;
                Notify("Winner");
            }
        }
        string WhoIsWinner() {
            string text = "";
            if (PlayerChoice.Value == MachineChoice.Value)
                text = "Draw";
            else
            {
                if (PlayerChoice.Value == 0)
                {
                    if (MachineChoice.Value == 2)
                        text = "Player is a Winner";
                    else
                        text = "Machine is a Winner";
                }
                if (PlayerChoice.Value == 1)
                {
                    if (MachineChoice.Value == 0)
                        text = "Player is a Winner";
                    else
                        text = "Machine is a Winner";
                }
                if (PlayerChoice.Value == 2)
                {
                    if (MachineChoice.Value == 1)
                        text = "Player is a Winner";
                    else
                        text = "Machine is a Winner";
                }
            }
            return text;
        }
        void MakeChoice(object parameter) {
            Random random = new Random();
            PlayerChoice = new RPS(Convert.ToInt32(parameter.ToString()));
            MachineChoice = new RPS(random.Next(3));
            Winner = WhoIsWinner();
        }
        public ButtonCommand Turn
        {
            get {
                return new ButtonCommand(MakeChoice);
            }
        }
    }
}

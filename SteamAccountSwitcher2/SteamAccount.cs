﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAccountSwitcher2
{
    public class SteamAccount
    {
        string name;
        string username;
        string password;
        AccountType type;

        public SteamAccount()
        {

        }

        public SteamAccount(string username, string password)
        {
            this.name = username;
            this.username = username;
            this.password = password;
            this.type = AccountType.본계정;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Username
        {
            get { return username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public AccountType Type
        {
            get { return type; }
            set { this.type = value; }
        }

        public string Icon
        {
            get
            {
                if (this.type == AccountType.본계정)
                {
                    return "steam-ico-main.png";
                }
                if (this.type == AccountType.부계정)
                {
                    return "steam-ico-smurf.png";
                }
                return null;
            }
        }

        public string getStartParameters()
        {
            return "-login " + this.username + " " + this.password;
        }
        public override string ToString()
        {
            return name + "~ (user: " + username + ")";
        }
    }
}

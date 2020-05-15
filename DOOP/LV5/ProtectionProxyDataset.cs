﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class ProtectionProxyDataset : IDataset
    {
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        public ProtectionProxyDataset(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 1, 3, 5 });
            this.user = user;
        }
        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (this.AuthenticateUser())
            {
                if (this.dataset == null)
                {
                    this.dataset = new Dataset(@"C:\Users\tin_k\Documents\DOOP-LV\DOOP\LV5\Test.csv");
                }
                return this.dataset.GetData();
            }
            return null;
        }

    }
}

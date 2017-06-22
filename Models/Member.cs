using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_0622_login1.Models {
    public class Member {

        public string id { get; set; }
        public string password { get; set; }
        public bool validata() {
            int errorCount = 0;
            if (string.IsNullOrEmpty(id)) {
                errorCount++;
            }

            if (string.IsNullOrEmpty(password)) {
                errorCount++;
            }

            return (errorCount == 0);
         }       
    }
}
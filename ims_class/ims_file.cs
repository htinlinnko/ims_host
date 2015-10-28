using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims_class
{
    public class ims_file
    {
        public ims_file()
        {
            // Constructor
        }

        #region Class Variable
        string file_name;

        int branch_id;

        string branch_name;

        DateTime exported_for;

        int exported_count;

        int? staff_id;

        string staff_name;

        DateTime created_date;

        public string File_name
        {
            get
            {
                return file_name;
            }

            set
            {
                file_name = value;
            }
        }

        public int Branch_id
        {
            get
            {
                return branch_id;
            }

            set
            {
                branch_id = value;
            }
        }

        public string Branch_name
        {
            get
            {
                return branch_name;
            }

            set
            {
                branch_name = value;
            }
        }

        public DateTime Exported_for
        {
            get
            {
                return exported_for;
            }

            set
            {
                exported_for = value;
            }
        }

        public int Exported_count
        {
            get
            {
                return exported_count;
            }

            set
            {
                exported_count = value;
            }
        }

        public int? Staff_id
        {
            get
            {
                return staff_id;
            }

            set
            {
                staff_id = value;
            }
        }

        public string Staff_name
        {
            get
            {
                return staff_name;
            }

            set
            {
                staff_name = value;
            }
        }

        public DateTime Created_date
        {
            get
            {
                return created_date;
            }

            set
            {
                created_date = value;
            }
        }
        #endregion
    }
}

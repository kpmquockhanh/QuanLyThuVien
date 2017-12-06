using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Category
    {
        DAO_Category categoryDAO = new DAO_Category();
        DAO_Category dataCategory = new DAO_Category();
        DataTable dataTable = new DataTable();
        DTO_Category dto_category = new DTO_Category();
        public int InsertCategory(DTO_Category category)
        {
            if (category.Category_name.Contains("'"))
            {
                category.Category_name = checkString(category.Category_name);
            }
            return categoryDAO.Insert(category);
        }


        public DataTable LoadDataGridViewCategory()
        {
            return dataTable = categoryDAO.GetAllDataTable();
        }
        public DTO_Category SearchCategory(String condition, String value)
        {
            dataTable = categoryDAO.GetDataTableBy(condition, value);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dto_category.Category_name = row["category_name"].ToString();
                    dto_category.Category_id = int.Parse(row["category_id"].ToString());
                    return dto_category;

                }
            }
            return null;
        }

        public int UpdateCategory(DTO_Category category)
        {
            try
            {
                if (category.Category_name.Contains("'"))
                {
                    category.Category_name = checkString(category.Category_name);
                }
                return categoryDAO.Update(category);
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int DeleteCategory(DTO_Category category)
        {
            try
            {
                if (category.Category_name.Contains("'"))
                {
                    category.Category_name = checkString(category.Category_name);
                }
                return categoryDAO.Delete(category.Category_name);
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public String checkString(String name)
        {
            String[] tmp = name.Split('\'');
            String text = null;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == tmp.Length - 1)
                {
                    text += tmp[i];
                }
                else
                {
                    text += tmp[i];
                    text += "''";
                }
            }
            return text;
        }
    }
}

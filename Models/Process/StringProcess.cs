namespace DangThiAnhBTH.Models.Process
{
    public class stringProcess
    {
        public string RemoveRemainingWhiteSpace (string strInput)
        {
            string result = "";
            //viet code xu ly cac ki tu con thua
            //xoa bo ki tu trang o dau va cuoi chuoi
            strInput = strInput.Trim();
            //xoa bo cac kí tu trang con thua ơ giưax chuoi
            int index = strInput.IndexOf(" ");
            while(strInput.IndexOf(" ") > 0){
                strInput = strInput.Replace("  ", " ");
            }
            result = strInput;
            return result;
        }
    
    }
}
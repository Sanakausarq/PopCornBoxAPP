public bool file(string sp, string dp, string fn)
        {
 
            sourcePath = Path.Combine(sp, fn);
            if (!Directory.Exists(dp))
                Directory.CreateDirectory(dp);
 
            bool isCopied = false;
            
            {
                dp = Path.Combine(dp, vf);
 
                if (File.Exists(dp))--this
                {
                    File.Move(dp, dp);
                    File.Copy(sp, dp, false);
                    isCopied = true;
                }
               
            
        }		 
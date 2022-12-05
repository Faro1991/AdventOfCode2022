namespace AdventOfCode2022.HelperObjects.DataTypes
{
    class CrateStack
    {
        private List<string> _crates = new List<string>();
        public bool PushCrate(string Crate)
        {
            try
            {
                this._crates.Add(Crate);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public string PopCrate()
        {
            var Last = this._crates.Last();
            this._crates.RemoveAt(this._crates.Count - 1); 
            return Last;
        }
    }
}
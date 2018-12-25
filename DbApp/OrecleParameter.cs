using Oracle.ManagedDataAccess.Client;

namespace DBapp
{
    internal class OrecleParameter
    {
        private string v1;
        private OracleDbType @char;
        private int v2;

        public OrecleParameter(string v1, OracleDbType @char, int v2)
        {
            this.v1 = v1;
            this.@char = @char;
            this.v2 = v2;
        }

        public string Value { get; internal set; }
    }
}
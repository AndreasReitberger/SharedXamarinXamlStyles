namespace AndreasReitberger.Shared.Models.Filtering
{
    public class ListViewFilterProperty
    {
        #region Properties
        public string LocalisedName { get; set; } = "";
        public string Property { get; set; }
        #endregion

        #region overrides
        public override string ToString()
        {
            return LocalisedName;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is ListViewFilterProperty item))
                return false;
            return Property.Equals(item.Property);
        }
        public override int GetHashCode()
        {
            return Property.GetHashCode();
        }
        #endregion
    }
}

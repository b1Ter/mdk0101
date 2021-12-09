//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FabricStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.MaterialDeliveries = new HashSet<MaterialDelivery>();
            this.SaleMaterials = new HashSet<SaleMaterial>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Type { get; set; }
        public byte[] Image { get; set; }
        public double Price { get; set; }

        public double Delivered
        {
            get
            {
                bdMaterialsEntities context = new bdMaterialsEntities();
                double delivered;
                if (context.MaterialDeliveries.Any(x => x.Material == ID))
                    delivered = (from x in context.MaterialDeliveries
                                 where ID == x.Material
                                 select x.CountMeters).Sum();
                else delivered = 0;
                return delivered;
            }
            set
            {  }
        }
        public double Sold
        {
            get
            {
                bdMaterialsEntities context = new bdMaterialsEntities();
                double Sold;
                if (context.MaterialDeliveries.Any(x => x.Material == ID))
                    Sold = (from x in context.SaleMaterials
                            where ID == x.Material
                            select x.Count).Sum();
                else Sold = 0;
                return Sold;
            }
            set
            { }
        }
        public double Remaining
        {
            get
            {
                return Delivered - Sold;
            }
            set
            { }
        }
        public double Revenge
        {
            get
            {
                return Sold*Price;
            }
            set
            { }
        }

        public virtual TypeMaterial TypeMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialDelivery> MaterialDeliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleMaterial> SaleMaterials { get; set; }
    }
}
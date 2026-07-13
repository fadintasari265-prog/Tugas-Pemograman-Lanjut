namespace Inventaris_Lahan.Domain.Entities
{
    public abstract class KavlingGeometri
    {
        public abstract double HitungLuas();
    }

    public class PersegiKavling : KavlingGeometri
    {
        public double Sisi { get; set; }
        public override double HitungLuas() => Sisi * Sisi;
    }

    public class PersegiPanjangKavling : KavlingGeometri
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }
        public override double HitungLuas() => Panjang * Lebar;
    }

    public class LingkaranKavling : KavlingGeometri
    {
        public double JariJari { get; set; }
        public override double HitungLuas() => Math.PI * JariJari * JariJari;
    }
}
namespace Application.Dto
{
    public class InformeEnsayoGlpEntidadDto : InformeEnsayoEntidadDto
    {
        public string Observaciones { get; set; }
        public string NumeroInformeLaboratorio { get; set; }
        public float? DensidadRelativa { get; set; }
        public float? PresionVapor { get; set; }
        public string NumeroOctanoMotor { get; set; }
        public string MetanoMol { get; set; }
        public string EtanoMol { get; set; }
        public string EtilenoMol { get; set; }
        public float? PropanoMol { get; set; }
        public string PropilenoMol { get; set; }
        public float? IsobutanoMol { get; set; }
        public float? NbutanoMol { get; set; }
        public string Trans2butenoMol { get; set; }
        public string ButenoMol { get; set; }
        public string IsobutilenoMol { get; set; }
        public float? Cis2butenoMol { get; set; }
        public float? IsopentanoMol { get; set; }
        public string NpentanoMol { get; set; }
        public string ButadienoMol { get; set; }
        public string Hexano { get; set; }
        public string CorrosionLaminaCobre { get; set; }
        public float? DeterminacionEtilMercaptano { get; set; }
    }
}

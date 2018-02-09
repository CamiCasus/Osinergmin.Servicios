using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class InformeEnsayoGlpEntity : InformeEnsayoEntity
    {
        public string Observaciones { get; set; }
        public string NumeroInformeLaboratorio { get; set; }
        public int DensidadRelativa { get; set; }
        public int PresionVapor { get; set; }
        public string NumeroOctanoMotor { get; set; }
        public string MetanoMol { get; set; }
        public string EtanoMol { get; set; }
        public string EtilenoMol { get; set; }
        public int PropanoMol { get; set; }
        public string PropilenoMol { get; set; }
        public int IsobutanoMol { get; set; }
        public int NbutanoMol { get; set; }
        public string Trans2butenoMol { get; set; }
        public string ButenoMol { get; set; }
        public string IsobutilenoMol { get; set; }
        public int Cis2butenoMol { get; set; }
        public int IsopentanoMol { get; set; }
        public string NpentanoMol { get; set; }
        public string ButadienoMol { get; set; }
        public string Hexano { get; set; }
        public string CorrosionLaminaCobre { get; set; }
        public int DeterminacionEtilMercaptano { get; set; }        
    }
}

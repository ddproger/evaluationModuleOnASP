﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public enum TypeIA
    {
        BT,
        PIDm,
        KrD,
        KT,
        StO,
        Ol,
        YI,
        PD
    }
    public class InformationAssets : NetworkEntity
    {
        public TypeIA type { get; set; }
        public long cost { get; set; }
        public long investment { get; set; }
        public bool aConfidentiality { get; set; }
        public bool aAvailability { get; set; }
        public bool aAuthenticity { get; set; }
        public bool aIntegrity { get; set; }
        public bool continuity { get; set; }
        public IList<InformationRisk> risks { get; set; }

        public InformationAssets(String name):base(TypeEntity.InformationAssets,name)
        {
        }
        public InformationAssets(TypeIA t, String name, bool aConfidentiality,
                                bool aAvailability, bool aAuthenticity,
                                bool aIntegrity, bool continuity) : base(TypeEntity.InformationAssets,name)
        {
            this.cost = 0;
            this.type = t;
            this.aConfidentiality = aConfidentiality;
            this.aAvailability = aAvailability;
            this.aAuthenticity = aAuthenticity;
            this.aIntegrity = aIntegrity;
            this.continuity = continuity;


        }
    }
}

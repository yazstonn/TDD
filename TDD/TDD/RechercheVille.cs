﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TDD
{
    public class RechercheVille
    {
        private List<String> _villes;

        public RechercheVille()
        {
            _villes = new List<String>() { "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" };
        }

        public List<String> Rechercher(String mot)
        {
            throw new NotImplementedException();
        }
    }

}

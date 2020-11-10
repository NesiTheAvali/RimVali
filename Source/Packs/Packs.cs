﻿using RimWorld;
using Verse;
using System.Collections.Generic;

namespace AvaliMod
{
    public class AvaliPack : IExposable
    {
        public string name = "NoName";
        public List<Pawn> pawns = new List<Pawn>();
        public int size = 1;
        public Faction faction = null;
        public List<DeathDate> deathDates;
        public Date creationDate;
       public void ExposeData()
        {
            Scribe_Values.Look(ref name, "packName", "NoName", true);
            Scribe_Values.Look(ref pawns, "pawns", null, true);
            Scribe_Values.Look(ref size, "size", 1, true);
            Scribe_Values.Look(ref faction, "faction", null, true);
            Scribe_Values.Look(ref deathDates, "deathDates", null, true);
            Scribe_Values.Look(ref creationDate, "creationDate", null, true);
        }
    }

    public class Date
    {
        public int day;
        public Quadrum quadrum;
    }
    public class DeathDate : Date
    {
        public Pawn deadPawn;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable()]
public class SaveData
{
    public List<EventData> EventList;
    
    public SaveData()
    {
        EventList = new List<EventData>();
    }

    public void AddItem (int id, int odvd, int odvr, int ogvd, int ogvr, int osvd, int osvr, string title, string desc, string ra, string rb, string rc, string rd, string ba, string bb, string bc, string bd, int omoney, int sdvd, int sdvr, int sgvd, int sgvr, int ssvd, int ssvr, int smoney, int tdvd, int tdvr, int tgvd, int tgvr, int tsvd, int tsvr, int tmoney, int fdvd, int fdvr, int fgvd, int fgvr, int fsvd, int fsvr, int fmoney)
    {
        EventList.Add(new EventData(id, odvd, odvr, ogvd, ogvr, osvd, osvr, title, desc, ra, rb, rc, rd, ba, bb, bc, bd, omoney, sdvd, sdvr, sgvd, sgvr, ssvd, ssvr, smoney, tdvd, tdvr, tgvd, tgvr, tsvd, tsvr, tmoney, fdvd, fdvr, fgvd, fgvr, fsvd, fsvr, fmoney));
    }

    public int DataSize()
    {
        return EventList.Count; 
    }
}

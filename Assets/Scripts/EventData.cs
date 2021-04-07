using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable()]

public class EventData
{
    public int eventID;
    public int b1dinoValueDiff;
    public int b1dinoValueRequirement;
    public int b1guestValueDiff;
    public int b1guestValueRequirement;
    public int b1securityValueDiff;
    public int b1securityValueRequirement;
    public int b1moneyDiff;

    public int b2dinoValueDiff;
    public int b2dinoValueRequirement;
    public int b2guestValueDiff;
    public int b2guestValueRequirement;
    public int b2securityValueDiff;
    public int b2securityValueRequirement;
    public int b2moneyDiff;

    public int b3dinoValueDiff;
    public int b3dinoValueRequirement;
    public int b3guestValueDiff;
    public int b3guestValueRequirement;
    public int b3securityValueDiff;
    public int b3securityValueRequirement;
    public int b3moneyDiff;

    public int b4dinoValueDiff;
    public int b4dinoValueRequirement;
    public int b4guestValueDiff;
    public int b4guestValueRequirement;
    public int b4securityValueDiff;
    public int b4securityValueRequirement;
    public int b4moneyDiff;
    public string titleString;
    public string descriptorString;
    public string result1String;
    public string result2String;
    public string result3String;
    public string result4String;
    public string buttonOneString;
    public string buttonTwoString;
    public string buttonThreeString;
    public string buttonFourString;

    public EventData()
    { }

    public EventData(int id,  int odvd, int odvr, int ogvd, int ogvr, int osvd, int osvr, string title, string desc, string ra, string rb, string rc, string rd, string ba, string bb, string bc, string bd, int omoney, int sdvd, int sdvr, int sgvd, int sgvr, int ssvd, int ssvr, int smoney, int tdvd, int tdvr, int tgvd, int tgvr, int tsvd, int tsvr, int tmoney, int fdvd, int fdvr, int fgvd, int fgvr, int fsvd, int fsvr, int fmoney)
    {
        eventID = id;
        b1dinoValueDiff = odvd;
        b1dinoValueRequirement = odvr;
        b1guestValueDiff = ogvd;
        b1guestValueRequirement = ogvr;
        b1securityValueDiff = osvd;
        b1securityValueRequirement = osvr;
        titleString = title;
        descriptorString = desc;
        result1String = ra;
        buttonOneString = ba;
        result2String = rb;
        buttonTwoString = bb;
        result3String = rc;
        buttonThreeString = bc;
        result4String = rd;
        buttonFourString = bd;
        b1moneyDiff = omoney;

        b2dinoValueDiff = sdvd;
        b2dinoValueRequirement = sdvr;
        b2guestValueDiff = sgvd;
        b2guestValueRequirement = sgvr;
        b2securityValueDiff = ssvd;
        b2securityValueRequirement = ssvr;
        b2moneyDiff = smoney;

        b3dinoValueDiff = tdvd;
        b3dinoValueRequirement = tdvr;
        b3guestValueDiff = tgvd;
        b3guestValueRequirement = tgvr;
        b3securityValueDiff = tsvd;
        b3securityValueRequirement = tsvr;
        b3moneyDiff = tmoney;

        b4dinoValueDiff = fdvd;
        b4dinoValueRequirement = fdvr;
        b4guestValueDiff = fgvd;
        b4guestValueRequirement = fgvr;
        b4securityValueDiff = fsvd;
        b4securityValueRequirement = fsvr;
        b4moneyDiff = fmoney;
    }

}

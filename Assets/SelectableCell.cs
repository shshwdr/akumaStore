using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SelectableCell:MonoBehaviour
{
    public TMP_Text nameLabel;
    public TMP_Text descLabel;
    public TowerInfo info;
    public void init(TowerInfo _info)
    {
        info = _info;
        nameLabel.text = info.displayName;
        descLabel.text = info.description;
    }
}
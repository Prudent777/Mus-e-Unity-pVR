﻿//   Assembly-CSharp
//   Copyright (C) 2020  Ye William
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionStartup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Current Directory: {System.IO.Directory.GetCurrentDirectory()}");
        Muser.Runtime.Consts.sheetGroups = System.IO.Directory.GetDirectories($"Assets{Muser.Runtime.Consts.separator}DefaultSheets");
        foreach (string path in Muser.Runtime.Consts.sheetGroups) {
            Debug.Log($"Sheet Group Entry: {path}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
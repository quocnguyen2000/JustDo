using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class UserModel
{
    public string id { get; set; }
    public string username { get; set; }
    public string located { get; set; }
    public string password { get; set; }

    public UserModel(string id, string username, string located, string password)
    {
        this.id = id;
        this.username = username;
        this.located = located;
        this.password = password;
    }
    public UserModel(string id)
    {
        this.id = id;
    }
}

    
        


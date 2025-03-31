using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


[CreateAssetMenu(fileName = "DialogDatabase", menuName = "Dialog System/Database")]

public class DialogDatabaseSO : ScriptableObject
{
    public List<DialogSO> dialogs = new List<DialogSO>();

    private Dictionary<int, DialogSO> dialogByld;

    public void initailize()
    {
        dialogByld = new Dictionary<int, DialogSO>();

        foreach (var dialog in dialogs)
        {
            if (dialog != null)
            {
                dialogByld[dialog.id] = dialog;
            }
        }
    }

    public DialogSO GetDialogByld(int id)
    {
        if (dialogByld == null)
               initailize();
        
        if(dialogByld.TryGetValue(id, out DialogSO dialog))
            return dialog;

        return null;


       
    }
}

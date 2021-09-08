using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace MSCP.UI
{
    internal sealed class CreamPuffsButton : MonoBehaviour
    {
        [SerializeField] private Button button;

        private void Awake()
        {
            if (button != null)
            {
                button.OnClickAsObservable()
                    .TakeUntilDestroy(this)
                    .Subscribe(_ =>
                    {
                        Debug.Log("OnClick");
                    });
            }
        }
    }
}

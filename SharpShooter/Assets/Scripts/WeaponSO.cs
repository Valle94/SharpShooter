using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Scriptable Objects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public int Damage = 1;
    public float Firerate = 0.5f;
    public ParticleSystem hitVFXPrefab;
    public bool IsAutomatic = false;
}

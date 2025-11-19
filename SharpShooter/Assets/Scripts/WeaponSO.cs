using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Scriptable Objects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public GameObject weaponPrefab;
    public int Damage = 1;
    public float Firerate = 0.5f;
    public ParticleSystem hitVFXPrefab;
    public bool IsAutomatic = false;
    public bool CanZoom = false;
    public float ZoomAmount = 10f;
    public float ZoomRotationSpeed = 0.3f;
    public int MagazineSize = 12;
}

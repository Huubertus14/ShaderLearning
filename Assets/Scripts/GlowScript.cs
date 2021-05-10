using UnityEngine;

public class GlowScript : MonoBehaviour
{
	[SerializeField]
	private Material _material;

	private void OnMouseOver()
	{
		_material.SetColor("_EmissionColor", new Color(1, 1, 1));
	}

	private void OnMouseExit()
	{
		_material.SetColor("_EmissionColor", new Color(1, 0, 0));
	}
}

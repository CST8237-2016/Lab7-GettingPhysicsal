using UnityEngine;

public class Infection : MonoBehaviour {
  public Color infectedColor;
  private Color _oldColor;

  private Material _rendererMaterial;
  private float _elapsedTime = 0.0f;

	// Use this for initialization
	void Start () {
    MeshRenderer renderer = GetComponent<MeshRenderer>();

    if(renderer != null) {
      _rendererMaterial = renderer.material;

      _oldColor = _rendererMaterial.color;
    }
	}
	
	// Update is called once per frame
	void Update () {
    if(_elapsedTime < 1.0f) {
      _elapsedTime += Time.deltaTime;

      _rendererMaterial.color = Color.Lerp(_oldColor, infectedColor, _elapsedTime);
    }
	}
}

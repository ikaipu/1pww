using UnityEngine;
using UnityEngine.UI;

public class ListViewController : MonoBehaviour
{

	public RectTransform chatNodePrefab;

	private void Start()
	{
		Instantiate(chatNodePrefab);
		for (var i = 0; i < 15; i++)
		{
			var chatNodeInst = Instantiate(chatNodePrefab);
			chatNodeInst.SetParent(transform, false);

			var text = chatNodeInst.GetComponentInChildren<Text>();
			text.text = "item:" + i;
		}
	}
}

using UnityEngine;

namespace GENEX
{
	public class SystemMarbleEat : MonoBehaviour
	{
		private string nameMarblePlayer = "�u�]";
		private SystemTurn systemTurn;
		private void Awake()
		{
			systemTurn = FindObjectOfType<SystemTurn>();
		}
		private void OnTriggerEnter(Collider other)
		{
			if (other.name.Contains(nameMarblePlayer))
			{
				systemTurn.MarbleEat();
				Destroy(gameObject);
			}
		}

	}
}
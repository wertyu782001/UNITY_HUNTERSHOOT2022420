using UnityEngine;


namespace GENEX
{
	public class SystemAttack : MonoBehaviour
	{
		[SerializeField, Header("�������")]
		private DataAttack dataAttack;

		/// <summary>
		/// �����ƭ�
		/// </summary>
		public float valueAttack;

		private void Awake()
		{
			//�����ƭ� = �����O + �d��(-�����B�� + �����B��)
			// �Ҧp: �����ƭ� = 100 + (-10, 10): �d�򸨦b 90 ~ 110
			valueAttack = dataAttack.attack +
				Random.Range(-dataAttack.attackFloat, dataAttack.attackFloat);

			valueAttack = Mathf.Floor(valueAttack);
		}
	}
}
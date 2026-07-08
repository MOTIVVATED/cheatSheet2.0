using System;
using System.Collections;
using UnityEngine;

public class WeaponShooting : MonoBehaviour
{
	interface IHasInfo
	{
		void ShowInfo();
	}	

	interface IWeapon
	{
		int Damage { get; }
		void Fire();
	}

	abstract class Weapon : IHasInfo, IWeapon
	{
		public abstract int Damage { get; }
		
		public abstract void Fire();

		public void ShowInfo()
		{
			Debug.Log($"{GetType().Name} - Damage: {Damage}");
		}
	}

	class Gun : Weapon
	{
		public override void Fire()
		{
			Debug.Log("Bang!");
		}
		public override int Damage => 10;
	}

	class Laser : Weapon
	{
		public override void Fire()
		{
			Debug.Log("Pew!");
		}
		public override int Damage => 15;
	}

	class Bow : Weapon
	{
		public override void Fire()
		{
			Debug.Log("Twang!");
		}
		public override int Damage => 8;
	}

	class Box : IHasInfo
	{
		public void ShowInfo()
		{
			Debug.Log("This is a box.");
		}
	}

	class Player
	{
		public void FireWeapon(Weapon weapon)
		{
			weapon.Fire();
		}

		public void CheckInfo(IHasInfo hasInfo)
		{
			hasInfo.ShowInfo();
		}
	}

	private void Start()
	{
		Player player = new Player();

		Weapon[] inventory = { new Gun(), new Laser(), new Bow() };

		foreach (var item in inventory)
		{
			player.CheckInfo(item);
			player.FireWeapon(item);
		}
		player.CheckInfo(new Box());
	}
}

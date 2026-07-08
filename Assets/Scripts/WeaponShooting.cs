using System;
using System.Collections;
using UnityEngine;

public class WeaponShooting : MonoBehaviour
{
	abstract class Weapon
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

	class Player
	{
		public void FireWeapon(Weapon weapon)
		{
			weapon.Fire();
		}

		public void ShowWeaponTifo(Weapon weapon)
		{
			weapon.ShowInfo();
		}
	}

	private void Start()
	{
		Player player = new Player();

		Weapon[] inventory = { new Gun(), new Laser(), new Bow() };

		foreach (var item in inventory)
		{
			player.ShowWeaponTifo(item);
			player.FireWeapon(item);
		}
	}
}

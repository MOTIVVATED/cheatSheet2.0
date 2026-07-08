using UnityEngine;

public class ShootingThrowing : MonoBehaviour
{
  interface IWeapon
  {
    void Fire();
  }

  interface IThrowable : IWeapon
	{
    void Throw();
	}

	class Gun : IWeapon
  {
    public void Fire()
    {
      Debug.Log("Bang!");
    }
	}

	class Laser : IWeapon
  {
    public void Fire()
    {
      Debug.Log("Pew!");
    }
	}

  class Knife : IThrowable
  {
    public void Throw()
    {
      Debug.Log("Throwing knife!");
    }
	
    public void Fire()
    {
      Debug.Log("Slash!");
    }
  }
     
	class Player
  {
    public void Fire(IWeapon weapon)
    {
      weapon.Fire();
		}

    public void Throw(IThrowable throwable)
    {
      throwable.Throw();
		}
	}



	void Start()
  {
    Player player = new Player();

    IWeapon[] inventory = { new Gun(), new Laser(), new Knife() };

    foreach (var item in inventory)
    {
      player.Fire(item);
		}

    player.Throw(new Knife());
	}
}

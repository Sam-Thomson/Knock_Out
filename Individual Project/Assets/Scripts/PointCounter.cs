using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour {
	public int boxer1Points;
	public int boxer2Points;

	public void boxer1Attack1Points(){
		boxer1Points++;
	}

	public void boxer1Attack2Points(){
		boxer1Points = boxer1Points + 2;
	}

	public void boxer1DefencePoints(){
		boxer1Points = boxer1Points + 2;
	}

	public void boxer2Attack1Points(){
		boxer2Points++;
	}

	public void boxer2Attack2Points(){
		boxer2Points = boxer2Points + 2;
	}

	public void boxer2DefencePoints(){
		boxer2Points = boxer2Points + 2;
	}
	public void resetPoints(){
		boxer1Points = 0;
		boxer2Points = 0;
	}
}

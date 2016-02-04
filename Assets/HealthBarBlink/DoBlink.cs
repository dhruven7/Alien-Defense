using UnityEngine;
using System.Collections;

public class DoBlink: IDoBlink{
	
	 IEnumerator IDoBlink.doBlink(SpriteRenderer healthBar,float health){
		//blink it forever. You can set a terminating condition depending upon your requirement
		
		//set the Text's text to blank
		healthBar.material.color = Color.white;
		//display blank text for 0.1 seconds
		yield return new WaitForSeconds(.1f);
		//display “I AM FLASHING TEXT” for the next 0.1 seconds
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
		yield return new WaitForSeconds(.1f);
		healthBar.material.color = Color.white;
		yield return new WaitForSeconds(.1f);
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
		yield return new WaitForSeconds(.1f);
		healthBar.material.color = Color.white;
		yield return new WaitForSeconds(.1f);
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
	}
}

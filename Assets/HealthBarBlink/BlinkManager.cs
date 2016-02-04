using UnityEngine;
using System.Collections;

public class BlinkManager : IDoBlink {

	private IDoBlink obj;
	
	public BlinkManager(IDoBlink obj) {
		this.obj = obj;
	}
	

	 IEnumerator IDoBlink.doBlink(SpriteRenderer healthBar,float health){
		return startWork (healthBar,health);
	}
	
	public IEnumerator startWork(SpriteRenderer healthBar,float health) {
		doEarlyWork();
		return obj.doBlink(healthBar,health);
		
	}
	
	public void doEarlyWork() {
	}

}

using UnityEngine;
using System.Collections;

public interface IDoBlink {
	 IEnumerator doBlink(SpriteRenderer healthBar,float health);
}
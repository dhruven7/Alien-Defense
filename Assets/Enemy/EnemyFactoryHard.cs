public class EnemyFactoryHard : IEnemyFactory {

	public IEnemyA createEnemyA(){
		return new EnemyA2 ();
	}
	public IEnemyB createEnemyB(){
		return new EnemyB2 ();
	}
}

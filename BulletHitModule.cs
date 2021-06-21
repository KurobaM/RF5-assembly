using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017C RID: 380
[Token(Token = "0x200012A")]
public abstract class BulletHitModule<T> : BulletSubModule where T : Component
{
	// Token: 0x060007F1 RID: 2033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C8")]
	public override void OnUpdate(BulletBase bullet)
	{
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C9")]
	private void UpdateDisableTimer()
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CA")]
	private void UpdateEffectIntervalTimer()
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00004BF0 File Offset: 0x00002DF0
	[Token(Token = "0x60006CB")]
	protected bool CheckHitDisable(T hit)
	{
		return default(bool);
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00004C08 File Offset: 0x00002E08
	[Token(Token = "0x60006CC")]
	public virtual bool OnHit(BulletBase bullet, T hit, Vector3 point, Vector3 normal)
	{
		return default(bool);
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CD")]
	private void PlayHitEffect(BulletBase bullet, T hit, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CE")]
	protected BulletHitModule()
	{
	}

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x4000380")]
	private const float effectMinInterval = 0.1f;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int maxHitCount;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public float Interval;

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public EffectID effectID;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public SoundID soundID;

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<T, int> m_HitList;

	// Token: 0x040004A0 RID: 1184
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<T, int> m_HitCounter;

	// Token: 0x040004A1 RID: 1185
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<T, BulletHitModule<T>.Timer> m_DisableTimer;

	// Token: 0x040004A2 RID: 1186
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_RemoveList;

	// Token: 0x040004A3 RID: 1187
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<T, BulletHitModule<T>.Timer> m_EffectTimer;

	// Token: 0x0200017D RID: 381
	[Token(Token = "0x2000FDB")]
	[Serializable]
	public class Timer
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00004C20 File Offset: 0x00002E20
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD1")]
		public float elapsed
		{
			[Token(Token = "0x6006C14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFDD0", Offset = "0x1AFED1")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006C15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFDE0", Offset = "0x1AFEE1")]
			set
			{
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C16")]
		public void Update(float deltaTime)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C17")]
		public Timer()
		{
		}

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x4018D8D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194DC0", Offset = "0x194EC1")]
		private float <elapsed>k__BackingField;
	}
}

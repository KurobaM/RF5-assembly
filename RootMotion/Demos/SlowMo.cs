using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000889")]
	public class SlowMo : MonoBehaviour
	{
		// Token: 0x060054BA RID: 21690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600469E")]
		[Address(RVA = "0x2863040", Offset = "0x2863141", VA = "0x2863040")]
		private void Update()
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x0001BE88 File Offset: 0x0001A088
		[Token(Token = "0x600469F")]
		[Address(RVA = "0x2863080", Offset = "0x2863181", VA = "0x2863080")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x2863150", Offset = "0x2863251", VA = "0x2863150")]
		public SlowMo()
		{
		}

		// Token: 0x0400B435 RID: 46133
		[Token(Token = "0x400875B")]
		[FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		// Token: 0x0400B436 RID: 46134
		[Token(Token = "0x400875C")]
		[FieldOffset(Offset = "0x20")]
		public bool mouse0;

		// Token: 0x0400B437 RID: 46135
		[Token(Token = "0x400875D")]
		[FieldOffset(Offset = "0x21")]
		public bool mouse1;

		// Token: 0x0400B438 RID: 46136
		[Token(Token = "0x400875E")]
		[FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;
	}
}

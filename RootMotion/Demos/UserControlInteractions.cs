using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;

namespace RootMotion.Demos
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000877")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		// Token: 0x0600544F RID: 21583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004641")]
		[Address(RVA = "0x2865AA0", Offset = "0x2865BA1", VA = "0x2865AA0", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004642")]
		[Address(RVA = "0x2865F20", Offset = "0x2866021", VA = "0x2865F20")]
		private void OnGUI()
		{
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x2866180", Offset = "0x2866281", VA = "0x2866180")]
		public UserControlInteractions()
		{
		}

		// Token: 0x0400B37C RID: 45948
		[Token(Token = "0x40086BF")]
		[FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		// Token: 0x0400B37D RID: 45949
		[Token(Token = "0x40086C0")]
		[FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		// Token: 0x0400B37E RID: 45950
		[Token(Token = "0x40086C1")]
		[FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		// Token: 0x0400B37F RID: 45951
		[Token(Token = "0x40086C2")]
		[FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;
	}
}

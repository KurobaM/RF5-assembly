using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Subtitle
{
	// Token: 0x02000E61 RID: 3681
	[Token(Token = "0x200096D")]
	public class UISubtitleHUDMain : MonoBehaviour
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060060BE RID: 24766 RVA: 0x000205C8 File Offset: 0x0001E7C8
		[Token(Token = "0x170009E4")]
		private float totalUsingHeight
		{
			[Token(Token = "0x600501A")]
			[Address(RVA = "0x2180750", Offset = "0x2180851", VA = "0x2180750")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501B")]
		[Address(RVA = "0x217F020", Offset = "0x217F121", VA = "0x217F020")]
		public void ClearAll()
		{
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501C")]
		[Address(RVA = "0x21804D0", Offset = "0x21805D1", VA = "0x21804D0")]
		public void EndVoice(SubtitleHandler handler)
		{
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x000205E0 File Offset: 0x0001E7E0
		[Token(Token = "0x600501D")]
		[Address(RVA = "0x2180AE0", Offset = "0x2180BE1", VA = "0x2180AE0")]
		private int GetNpcId(int voiceId)
		{
			return 0;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501E")]
		[Address(RVA = "0x2180B90", Offset = "0x2180C91", VA = "0x2180B90")]
		private string GetText(int voiceId)
		{
			return null;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501F")]
		[Address(RVA = "0x21808C0", Offset = "0x21809C1", VA = "0x21808C0")]
		private void StartHandler()
		{
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005020")]
		[Address(RVA = "0x217F4F0", Offset = "0x217F5F1", VA = "0x217F4F0")]
		public SubtitleHandler PlayHUDSubtitle(int _voiceId, AudioSource audioSource)
		{
			return null;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005021")]
		[Address(RVA = "0x217F6A0", Offset = "0x217F7A1", VA = "0x217F6A0")]
		public SubtitleHandler PlayHUDSubtitle(SkillID skillId)
		{
			return null;
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x2180C70", Offset = "0x2180D71", VA = "0x2180C70")]
		private void Awake()
		{
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x2180E80", Offset = "0x2180F81", VA = "0x2180E80")]
		private void OnDestroy()
		{
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005024")]
		[Address(RVA = "0x2180F40", Offset = "0x2181041", VA = "0x2180F40")]
		public UISubtitleHUDMain()
		{
		}

		// Token: 0x0400BFC8 RID: 49096
		[Token(Token = "0x4008F86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float paddingHeight;

		// Token: 0x0400BFC9 RID: 49097
		[Token(Token = "0x4008F87")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float limitHeight;

		// Token: 0x0400BFCA RID: 49098
		[Token(Token = "0x4008F88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISubtitleHUDBlock mainBlocks;

		// Token: 0x0400BFCB RID: 49099
		[Token(Token = "0x4008F89")]
		[FieldOffset(Offset = "0x28")]
		private SubtitleHudDataTable SubtitleHudDataTable;

		// Token: 0x0400BFCC RID: 49100
		[Token(Token = "0x4008F8A")]
		[FieldOffset(Offset = "0x30")]
		private UISystemTextData textData;

		// Token: 0x0400BFCD RID: 49101
		[Token(Token = "0x4008F8B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> DataDic;

		// Token: 0x0400BFCE RID: 49102
		[Token(Token = "0x4008F8C")]
		[FieldOffset(Offset = "0x40")]
		private List<SubtitleHandler> playingSubtitleHandlers;

		// Token: 0x0400BFCF RID: 49103
		[Token(Token = "0x4008F8D")]
		[FieldOffset(Offset = "0x48")]
		private List<SubtitleHandler> queSubtitleHandlers;

		// Token: 0x02000E62 RID: 3682
		[Token(Token = "0x2001460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159940", Offset = "0x159A41")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060060CA RID: 24778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B54")]
			[Address(RVA = "0x2181070", Offset = "0x2181171", VA = "0x2181070")]
			public <>c()
			{
			}

			// Token: 0x060060CB RID: 24779 RVA: 0x000205F8 File Offset: 0x0001E7F8
			[Token(Token = "0x6007B55")]
			[Address(RVA = "0x2181080", Offset = "0x2181181", VA = "0x2181080")]
			internal bool <ClearAll>b__10_0(SubtitleHandler a)
			{
				return default(bool);
			}

			// Token: 0x060060CC RID: 24780 RVA: 0x00020610 File Offset: 0x0001E810
			[Token(Token = "0x6007B56")]
			[Address(RVA = "0x21810A0", Offset = "0x21811A1", VA = "0x21810A0")]
			internal bool <ClearAll>b__10_1(SubtitleHandler a)
			{
				return default(bool);
			}

			// Token: 0x0400BFD0 RID: 49104
			[Token(Token = "0x401BC4E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UISubtitleHUDMain.<>c <>9;

			// Token: 0x0400BFD1 RID: 49105
			[Token(Token = "0x401BC4F")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<SubtitleHandler> <>9__10_0;

			// Token: 0x0400BFD2 RID: 49106
			[Token(Token = "0x401BC50")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<SubtitleHandler> <>9__10_1;
		}
	}
}

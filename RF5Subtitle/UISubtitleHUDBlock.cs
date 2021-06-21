using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RF5Subtitle
{
	// Token: 0x02000E60 RID: 3680
	[Token(Token = "0x200096C")]
	public class UISubtitleHUDBlock : MonoBehaviour
	{
		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x00020568 File Offset: 0x0001E768
		[Token(Token = "0x170009E3")]
		public float height
		{
			[Token(Token = "0x6005010")]
			[Address(RVA = "0x217FC20", Offset = "0x217FD21", VA = "0x217FC20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00020580 File Offset: 0x0001E780
		[Token(Token = "0x6005011")]
		[Address(RVA = "0x217FC60", Offset = "0x217FD61", VA = "0x217FC60")]
		private bool CheckChildNpcId(ChildData cData, bool isMale, ChildPersonality personality)
		{
			return default(bool);
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00020598 File Offset: 0x0001E798
		[Token(Token = "0x6005012")]
		[Address(RVA = "0x217FCA0", Offset = "0x217FDA1", VA = "0x217FCA0")]
		private int GetChildNpcId(bool isMale, ChildPersonality personality)
		{
			return 0;
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[Token(Token = "0x6005013")]
		[Address(RVA = "0x217FDC0", Offset = "0x217FEC1", VA = "0x217FDC0")]
		private int ConvNpcId(int id)
		{
			return 0;
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005014")]
		[Address(RVA = "0x217FE40", Offset = "0x217FF41", VA = "0x217FE40")]
		public void ForceEnd()
		{
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005015")]
		[Address(RVA = "0x217FE50", Offset = "0x217FF51", VA = "0x217FE50")]
		public void ResetHeight(float slideDown)
		{
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005016")]
		[Address(RVA = "0x217FF10", Offset = "0x2180011", VA = "0x217FF10")]
		public void Setup(SubtitleHandler _handler, string text, int npcid, int _dispNum, float slideDown)
		{
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005017")]
		[Address(RVA = "0x217E3B0", Offset = "0x217E4B1", VA = "0x217E3B0")]
		public void EndVoice()
		{
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005018")]
		[Address(RVA = "0x2180240", Offset = "0x2180341", VA = "0x2180240")]
		public void Update()
		{
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005019")]
		[Address(RVA = "0x2180720", Offset = "0x2180821", VA = "0x2180720")]
		public UISubtitleHUDBlock()
		{
		}

		// Token: 0x0400BFAC RID: 49068
		[Token(Token = "0x4008F6A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image iconImage;

		// Token: 0x0400BFAD RID: 49069
		[Token(Token = "0x4008F6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text Text;

		// Token: 0x0400BFAE RID: 49070
		[Token(Token = "0x4008F6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image borderImage;

		// Token: 0x0400BFAF RID: 49071
		[Token(Token = "0x4008F6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float baseWidth;

		// Token: 0x0400BFB0 RID: 49072
		[Token(Token = "0x4008F6E")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform rectTransform;

		// Token: 0x0400BFB1 RID: 49073
		[Token(Token = "0x4008F6F")]
		[FieldOffset(Offset = "0x40")]
		private float baseHeight;

		// Token: 0x0400BFB2 RID: 49074
		[Token(Token = "0x4008F70")]
		[FieldOffset(Offset = "0x48")]
		public SubtitleHandler handler;

		// Token: 0x0400BFB3 RID: 49075
		[Token(Token = "0x4008F71")]
		[FieldOffset(Offset = "0x50")]
		private int dispNum;

		// Token: 0x0400BFB4 RID: 49076
		[Token(Token = "0x4008F72")]
		[FieldOffset(Offset = "0x58")]
		private CanvasGroup canvasGroup;

		// Token: 0x0400BFB5 RID: 49077
		[Token(Token = "0x4008F73")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 posA;

		// Token: 0x0400BFB6 RID: 49078
		[Token(Token = "0x4008F74")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 posB;

		// Token: 0x0400BFB7 RID: 49079
		[Token(Token = "0x4008F75")]
		[FieldOffset(Offset = "0x70")]
		private float lifeTime;

		// Token: 0x0400BFB8 RID: 49080
		[Token(Token = "0x4008F76")]
		[FieldOffset(Offset = "0x74")]
		private float moveTime;

		// Token: 0x0400BFB9 RID: 49081
		[Token(Token = "0x4008F77")]
		private const float moveTimeMax = 0.2f;

		// Token: 0x0400BFBA RID: 49082
		[Token(Token = "0x4008F78")]
		[FieldOffset(Offset = "0x78")]
		private float appearTime;

		// Token: 0x0400BFBB RID: 49083
		[Token(Token = "0x4008F79")]
		private const float appearTimeMax = 0.1f;

		// Token: 0x0400BFBC RID: 49084
		[Token(Token = "0x4008F7A")]
		[FieldOffset(Offset = "0x7C")]
		private float disTime;

		// Token: 0x0400BFBD RID: 49085
		[Token(Token = "0x4008F7B")]
		private const float disTimeMax = 0.2f;

		// Token: 0x0400BFBE RID: 49086
		[Token(Token = "0x4008F7C")]
		[FieldOffset(Offset = "0x80")]
		private bool onDeleting;

		// Token: 0x0400BFBF RID: 49087
		[Token(Token = "0x4008F7D")]
		private const int NpcIdMax = 36;

		// Token: 0x0400BFC0 RID: 49088
		[Token(Token = "0x4008F7E")]
		private const int ChildBoyA = 36;

		// Token: 0x0400BFC1 RID: 49089
		[Token(Token = "0x4008F7F")]
		private const int ChildBoyB = 37;

		// Token: 0x0400BFC2 RID: 49090
		[Token(Token = "0x4008F80")]
		private const int ChildBoyC = 38;

		// Token: 0x0400BFC3 RID: 49091
		[Token(Token = "0x4008F81")]
		private const int ChildGirlA = 39;

		// Token: 0x0400BFC4 RID: 49092
		[Token(Token = "0x4008F82")]
		private const int ChildGirlB = 40;

		// Token: 0x0400BFC5 RID: 49093
		[Token(Token = "0x4008F83")]
		private const int ChildGirlC = 41;

		// Token: 0x0400BFC6 RID: 49094
		[Token(Token = "0x4008F84")]
		private const int SeedMobA = 42;

		// Token: 0x0400BFC7 RID: 49095
		[Token(Token = "0x4008F85")]
		private const int SeedMobB = 43;
	}
}

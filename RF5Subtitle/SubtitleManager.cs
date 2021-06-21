using System;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

namespace RF5Subtitle
{
	// Token: 0x02000E5F RID: 3679
	[Token(Token = "0x200096B")]
	public class SubtitleManager : SingletonMonoBehaviour<SubtitleManager>
	{
		// Token: 0x060060A0 RID: 24736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFC")]
		[Address(RVA = "0x217E460", Offset = "0x217E561", VA = "0x217E460")]
		private void ClearSubOnTitle()
		{
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFD")]
		[Address(RVA = "0x217E5D0", Offset = "0x217E6D1", VA = "0x217E5D0")]
		public void PlayOnTitle(int _voiceId, float _lifeTime = 5f)
		{
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFE")]
		[Address(RVA = "0x217E750", Offset = "0x217E851", VA = "0x217E750")]
		public void EndOnTitle()
		{
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFF")]
		[Address(RVA = "0x217E760", Offset = "0x217E861", VA = "0x217E760")]
		private void ClearVoiceComment()
		{
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005000")]
		[Address(RVA = "0x217E8E0", Offset = "0x217E9E1", VA = "0x217E8E0")]
		public void PlayVoiceComment(int _voiceId, AudioSource audioSource)
		{
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005001")]
		[Address(RVA = "0x217EA60", Offset = "0x217EB61", VA = "0x217EA60")]
		public void EndVoiceComment()
		{
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005002")]
		[Address(RVA = "0x217EA70", Offset = "0x217EB71", VA = "0x217EA70")]
		private void MovieLoaded(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005003")]
		[Address(RVA = "0x217EC00", Offset = "0x217ED01", VA = "0x217EC00")]
		private void ClearMovieSubtitle()
		{
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005004")]
		[Address(RVA = "0x2175940", Offset = "0x2175A41", VA = "0x2175940")]
		public void PlayMovieSubtitle(int _movieId, AudioSource audioSource)
		{
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005005")]
		[Address(RVA = "0x217ED50", Offset = "0x217EE51", VA = "0x217ED50")]
		public void PlayMovieSubtitle(int _movieId, MoviePlayer _moviePlayer)
		{
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005006")]
		[Address(RVA = "0x2175EB0", Offset = "0x2175FB1", VA = "0x2175EB0")]
		public void EndMovieSubtitle()
		{
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005007")]
		[Address(RVA = "0x217EF60", Offset = "0x217F061", VA = "0x217EF60")]
		public void SetHUDSubtitleEnable(bool enableState)
		{
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005008")]
		[Address(RVA = "0x217F340", Offset = "0x217F441", VA = "0x217F340")]
		public void SetHUDSubtitleEnableAlone(bool enableState)
		{
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005009")]
		[Address(RVA = "0x217F400", Offset = "0x217F501", VA = "0x217F400")]
		public SubtitleHandler PlayHUD(int _voiceId, AudioSource _audioSource)
		{
			return null;
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500A")]
		[Address(RVA = "0x217F5E0", Offset = "0x217F6E1", VA = "0x217F5E0")]
		public SubtitleHandler PlayHUD(SkillID skillID)
		{
			return null;
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500B")]
		[Address(RVA = "0x217F770", Offset = "0x217F871", VA = "0x217F770")]
		public SubtitleManager()
		{
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500C")]
		[Address(RVA = "0x217F7E0", Offset = "0x217F8E1", VA = "0x217F7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC710", Offset = "0x1AC811")]
		private void <PlayOnTitle>b__7_0(AssetHandle<UISystemTextData> texthandle)
		{
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500D")]
		[Address(RVA = "0x217F8D0", Offset = "0x217F9D1", VA = "0x217F8D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC720", Offset = "0x1AC821")]
		private void <PlayOnTitle>b__7_1(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x217FA00", Offset = "0x217FB01", VA = "0x217FA00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC730", Offset = "0x1AC831")]
		private void <PlayVoiceComment>b__16_0(AssetHandle<UISystemTextData> texthandle)
		{
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x217FAF0", Offset = "0x217FBF1", VA = "0x217FAF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC740", Offset = "0x1AC841")]
		private void <PlayVoiceComment>b__16_1(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x0400BF97 RID: 49047
		[Token(Token = "0x4008F55")]
		[FieldOffset(Offset = "0x18")]
		private bool isUsingTitle;

		// Token: 0x0400BF98 RID: 49048
		[Token(Token = "0x4008F56")]
		[FieldOffset(Offset = "0x1C")]
		private int titleVoiceId;

		// Token: 0x0400BF99 RID: 49049
		[Token(Token = "0x4008F57")]
		[FieldOffset(Offset = "0x20")]
		private UISubtitleTitle UISubtitleTitle;

		// Token: 0x0400BF9A RID: 49050
		[Token(Token = "0x4008F58")]
		[FieldOffset(Offset = "0x28")]
		private UISystemTextData TitleTextData;

		// Token: 0x0400BF9B RID: 49051
		[Token(Token = "0x4008F59")]
		[FieldOffset(Offset = "0x30")]
		private AssetHandle TitleHandle;

		// Token: 0x0400BF9C RID: 49052
		[Token(Token = "0x4008F5A")]
		[FieldOffset(Offset = "0x38")]
		private float lifeTime;

		// Token: 0x0400BF9D RID: 49053
		[Token(Token = "0x4008F5B")]
		[FieldOffset(Offset = "0x3C")]
		private bool isUsingVoiceComment;

		// Token: 0x0400BF9E RID: 49054
		[Token(Token = "0x4008F5C")]
		[FieldOffset(Offset = "0x40")]
		private int voiceId;

		// Token: 0x0400BF9F RID: 49055
		[Token(Token = "0x4008F5D")]
		[FieldOffset(Offset = "0x48")]
		private AudioSource voiceAudioSource;

		// Token: 0x0400BFA0 RID: 49056
		[Token(Token = "0x4008F5E")]
		[FieldOffset(Offset = "0x50")]
		private UISubtitleVoiceComment uiSubtitleVoiceComment;

		// Token: 0x0400BFA1 RID: 49057
		[Token(Token = "0x4008F5F")]
		[FieldOffset(Offset = "0x58")]
		private UISystemTextData VoiceTextData;

		// Token: 0x0400BFA2 RID: 49058
		[Token(Token = "0x4008F60")]
		[FieldOffset(Offset = "0x60")]
		private AssetHandle VoiceCommentHandle;

		// Token: 0x0400BFA3 RID: 49059
		[Token(Token = "0x4008F61")]
		[FieldOffset(Offset = "0x68")]
		private bool isUsingMovieSubtitle;

		// Token: 0x0400BFA4 RID: 49060
		[Token(Token = "0x4008F62")]
		[FieldOffset(Offset = "0x6C")]
		private int movieId;

		// Token: 0x0400BFA5 RID: 49061
		[Token(Token = "0x4008F63")]
		[FieldOffset(Offset = "0x70")]
		private MoviePlayer moviePlayer;

		// Token: 0x0400BFA6 RID: 49062
		[Token(Token = "0x4008F64")]
		[FieldOffset(Offset = "0x78")]
		private AudioSource movieAudioSource;

		// Token: 0x0400BFA7 RID: 49063
		[Token(Token = "0x4008F65")]
		[FieldOffset(Offset = "0x80")]
		private UISubtitleMovie uiSubtitleMovieSubtitle;

		// Token: 0x0400BFA8 RID: 49064
		[Token(Token = "0x4008F66")]
		[FieldOffset(Offset = "0x88")]
		private AssetHandle MovieSubtitleHandle;

		// Token: 0x0400BFA9 RID: 49065
		[Token(Token = "0x4008F67")]
		[FieldOffset(Offset = "0x90")]
		public UISubtitleHUDMain UISubtitleHUDMain;

		// Token: 0x0400BFAA RID: 49066
		[Token(Token = "0x4008F68")]
		[FieldOffset(Offset = "0x98")]
		private bool IsHUDSubtitleEnable;

		// Token: 0x0400BFAB RID: 49067
		[Token(Token = "0x4008F69")]
		[FieldOffset(Offset = "0x99")]
		private bool IsHUDSubtitleEnableWithoutHud;
	}
}

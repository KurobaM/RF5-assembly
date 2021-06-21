using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

// Token: 0x02000880 RID: 2176
[Token(Token = "0x20005A4")]
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
	// Token: 0x170007FC RID: 2044
	// (get) Token: 0x06003963 RID: 14691 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003964 RID: 14692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000641")]
	public AudioMixerGroup[] MixerVolumeGroups
	{
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x2257A10", Offset = "0x2257B11", VA = "0x2257A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E30", Offset = "0x1A5F31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x2257A20", Offset = "0x2257B21", VA = "0x2257A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E40", Offset = "0x1A5F41")]
		set
		{
		}
	}

	// Token: 0x170007FD RID: 2045
	// (get) Token: 0x06003965 RID: 14693 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003966 RID: 14694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000642")]
	public AudioSource MovieAudioSource
	{
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x2257A30", Offset = "0x2257B31", VA = "0x2257A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E50", Offset = "0x1A5F51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x2257A40", Offset = "0x2257B41", VA = "0x2257A40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E60", Offset = "0x1A5F61")]
		private set
		{
		}
	}

	// Token: 0x06003967 RID: 14695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x2257A50", Offset = "0x2257B51", VA = "0x2257A50")]
	public void RemoveAllResources()
	{
	}

	// Token: 0x170007FE RID: 2046
	// (get) Token: 0x06003968 RID: 14696 RVA: 0x00013DB8 File Offset: 0x00011FB8
	// (set) Token: 0x06003969 RID: 14697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000643")]
	public BGMID CurrentBGMID
	{
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x2257E30", Offset = "0x2257F31", VA = "0x2257E30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E70", Offset = "0x1A5F71")]
		get
		{
			return BGMID.BGM_EMPTY;
		}
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x2257E40", Offset = "0x2257F41", VA = "0x2257E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E80", Offset = "0x1A5F81")]
		private set
		{
		}
	}

	// Token: 0x0600396A RID: 14698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x2257E50", Offset = "0x2257F51", VA = "0x2257E50")]
	public void SetVolume(float value, MixerVolumeGroup mixerGroup)
	{
	}

	// Token: 0x0600396B RID: 14699 RVA: 0x00013DD0 File Offset: 0x00011FD0
	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x2258070", Offset = "0x2258171", VA = "0x2258070")]
	public float GetVolume(MixerVolumeGroup mixerGroup)
	{
		return 0f;
	}

	// Token: 0x0600396C RID: 14700 RVA: 0x00013DE8 File Offset: 0x00011FE8
	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x2258000", Offset = "0x2258101", VA = "0x2258000")]
	private ValueTuple<float, float> GetDecibelRange(MixerVolumeGroup mixerGroup)
	{
		return default(ValueTuple<float, float>);
	}

	// Token: 0x0600396D RID: 14701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x22581B0", Offset = "0x22582B1", VA = "0x22581B0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x22588C0", Offset = "0x22589C1", VA = "0x22588C0")]
	private void Start()
	{
	}

	// Token: 0x0600396F RID: 14703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x2258C30", Offset = "0x2258D31", VA = "0x2258C30")]
	public void Entry(BGMID id, [Optional] UnityAction<AudioClip> callback, int priority = 0)
	{
	}

	// Token: 0x06003970 RID: 14704 RVA: 0x00013E00 File Offset: 0x00012000
	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x2258D40", Offset = "0x2258E41", VA = "0x2258D40")]
	public bool IsLoaded(BGMID id)
	{
		return default(bool);
	}

	// Token: 0x06003971 RID: 14705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FF5")]
	private T FindFirstController<T>(IEnumerable<T> controllers, Func<T, bool> func) where T : class
	{
		return null;
	}

	// Token: 0x06003972 RID: 14706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FF6")]
	private IEnumerable<T> FindControllers<T>(IEnumerable<T> controllers, Func<T, bool> func) where T : class
	{
		return null;
	}

	// Token: 0x06003973 RID: 14707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FF7")]
	private T SearchUsableController<T, IDType>(LinkedList<T> controllers) where T : AudioSourceController<IDType> where IDType : Enum
	{
		return null;
	}

	// Token: 0x06003974 RID: 14708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x2258DC0", Offset = "0x2258EC1", VA = "0x2258DC0")]
	public void PlayBGM(BGMID id, float fadetime = 3f, int priority = 0)
	{
	}

	// Token: 0x06003975 RID: 14709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF9")]
	[Address(RVA = "0x2258DE0", Offset = "0x2258EE1", VA = "0x2258DE0")]
	private void PlayBGM_internal(BGMID id, float fadetime, int priority)
	{
	}

	// Token: 0x06003976 RID: 14710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FFA")]
	[Address(RVA = "0x2258EF0", Offset = "0x2258FF1", VA = "0x2258EF0")]
	public void PlaySE(SoundID id)
	{
	}

	// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x22590A0", Offset = "0x22591A1", VA = "0x22590A0")]
	private void PlayOneShot2D(SoundID id)
	{
	}

	// Token: 0x06003978 RID: 14712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x22591D0", Offset = "0x22592D1", VA = "0x22591D0")]
	public VoiceController PlayVoice(SoundID id, int priority = 0)
	{
		return null;
	}

	// Token: 0x06003979 RID: 14713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x2259350", Offset = "0x2259451", VA = "0x2259350")]
	public VoiceController PlayPlayerVoice(SoundID id)
	{
		return null;
	}

	// Token: 0x0600397A RID: 14714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x2259460", Offset = "0x2259561", VA = "0x2259460")]
	public SEController PlaySE(SoundID id, Vector3 position)
	{
		return null;
	}

	// Token: 0x0600397B RID: 14715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x2259ED0", Offset = "0x2259FD1", VA = "0x2259ED0")]
	public SEController PlaySE(SoundID id, Transform parent)
	{
		return null;
	}

	// Token: 0x0600397C RID: 14716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003000")]
	[Address(RVA = "0x2259550", Offset = "0x2259651", VA = "0x2259550")]
	private SEController PlaySE3D_internal(SoundID id, Vector3 targetPos)
	{
		return null;
	}

	// Token: 0x0600397D RID: 14717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003001")]
	[Address(RVA = "0x2259FE0", Offset = "0x225A0E1", VA = "0x2259FE0")]
	public void BackPool(SEController controller)
	{
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003002")]
	[Address(RVA = "0x225A090", Offset = "0x225A191", VA = "0x225A090")]
	public void StopAllBGM()
	{
	}

	// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003003")]
	[Address(RVA = "0x225A1B0", Offset = "0x225A2B1", VA = "0x225A1B0")]
	public void StopBGM(BGMID bgmID = BGMID.BGM_EMPTY)
	{
	}

	// Token: 0x06003980 RID: 14720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003004")]
	[Address(RVA = "0x225A2F0", Offset = "0x225A3F1", VA = "0x225A2F0")]
	public void PauseBGM()
	{
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003005")]
	[Address(RVA = "0x225A460", Offset = "0x225A561", VA = "0x225A460")]
	public void UnPauseBGM()
	{
	}

	// Token: 0x06003982 RID: 14722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003006")]
	[Address(RVA = "0x225A5D0", Offset = "0x225A6D1", VA = "0x225A5D0")]
	public void StopSound(SoundID soundID = SoundID.Sound_EMPTY)
	{
	}

	// Token: 0x06003983 RID: 14723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003007")]
	[Address(RVA = "0x225AC00", Offset = "0x225AD01", VA = "0x225AC00")]
	public void StopVoice(SoundID soundID = SoundID.Sound_EMPTY)
	{
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003008")]
	[Address(RVA = "0x225AF30", Offset = "0x225B031", VA = "0x225AF30")]
	public void StopPlayerVoice(SoundID soundID = SoundID.Sound_EMPTY)
	{
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003009")]
	[Address(RVA = "0x225AF60", Offset = "0x225B061", VA = "0x225AF60")]
	public void StopAllSound()
	{
	}

	// Token: 0x06003986 RID: 14726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600300A")]
	[Address(RVA = "0x225B150", Offset = "0x225B251", VA = "0x225B150")]
	public void StopAllVoice()
	{
	}

	// Token: 0x06003987 RID: 14727 RVA: 0x00013E18 File Offset: 0x00012018
	[Token(Token = "0x600300B")]
	[Address(RVA = "0x2259380", Offset = "0x2259481", VA = "0x2259380")]
	public static SoundID ConvertPlayerVoiceID(SoundID voiceID)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600300C")]
	[Address(RVA = "0x225B270", Offset = "0x225B371", VA = "0x225B270")]
	private static SoundManager CheckAndSpawnInstanceForRFViewer()
	{
		return null;
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600300D")]
	[Address(RVA = "0x225B300", Offset = "0x225B401", VA = "0x225B300")]
	public static void Timeline_PlayBGM(BGMID BGMID)
	{
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600300E")]
	[Address(RVA = "0x225B3E0", Offset = "0x225B4E1", VA = "0x225B3E0")]
	public static void Timeline_StopBGM()
	{
	}

	// Token: 0x0600398B RID: 14731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600300F")]
	[Address(RVA = "0x225B490", Offset = "0x225B591", VA = "0x225B490")]
	public static AudioSourceController<SoundID> Timeline_OnBehaviourPlay(SoundID soundID, RF_AudioBehaviour parent, bool isLoop, float volume, Transform targetTransform)
	{
		return null;
	}

	// Token: 0x0600398C RID: 14732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003010")]
	[Address(RVA = "0x225B830", Offset = "0x225B931", VA = "0x225B830")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x0600398D RID: 14733 RVA: 0x00013E30 File Offset: 0x00012030
	[Token(Token = "0x6003011")]
	[Address(RVA = "0x225B8E0", Offset = "0x225B9E1", VA = "0x225B8E0")]
	private float FindMaxVolume(IEnumerable<EnvironmentSoundArea> EnvironmentSoundAreas)
	{
		return 0f;
	}

	// Token: 0x0600398E RID: 14734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003012")]
	[Address(RVA = "0x225BBB0", Offset = "0x225BCB1", VA = "0x225BBB0")]
	public void OnEnterEnvironmentArea(EnvironmentSoundArea environmentSoundArea)
	{
	}

	// Token: 0x0600398F RID: 14735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003013")]
	[Address(RVA = "0x225BD50", Offset = "0x225BE51", VA = "0x225BD50")]
	public void OnExitEnvironmentArea(EnvironmentSoundArea environmentSoundArea)
	{
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003014")]
	[Address(RVA = "0x225BEA0", Offset = "0x225BFA1", VA = "0x225BEA0")]
	public void ReleaseEnvironmentArea()
	{
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003015")]
	[Address(RVA = "0x225BFE0", Offset = "0x225C0E1", VA = "0x225BFE0")]
	public void PlaySE_Debug(string name, Transform parent)
	{
	}

	// Token: 0x06003992 RID: 14738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003016")]
	[Address(RVA = "0x225C120", Offset = "0x225C221", VA = "0x225C120")]
	public void PlaySE_Debug(string name, Vector3 position)
	{
	}

	// Token: 0x06003993 RID: 14739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003017")]
	[Address(RVA = "0x225C1F0", Offset = "0x225C2F1", VA = "0x225C1F0")]
	public void StopSE_Debug(string name)
	{
	}

	// Token: 0x06003994 RID: 14740 RVA: 0x00013E48 File Offset: 0x00012048
	[Token(Token = "0x6003018")]
	[Address(RVA = "0x225C090", Offset = "0x225C191", VA = "0x225C090")]
	private SoundID StringToSoundID_Debug(string name)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x06003995 RID: 14741 RVA: 0x00013E60 File Offset: 0x00012060
	[Token(Token = "0x6003019")]
	[Address(RVA = "0x225C2F0", Offset = "0x225C3F1", VA = "0x225C2F0")]
	private BGMID StringToBGMID_Debug(string name)
	{
		return BGMID.BGM_EMPTY;
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600301A")]
	[Address(RVA = "0x225C380", Offset = "0x225C481", VA = "0x225C380")]
	public VoiceController PlayPlayerVoice_Debug(string name)
	{
		return null;
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600301B")]
	[Address(RVA = "0x225C440", Offset = "0x225C541", VA = "0x225C440")]
	public void StopVoice_Debug(string name)
	{
	}

	// Token: 0x06003998 RID: 14744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600301C")]
	[Address(RVA = "0x225C4E0", Offset = "0x225C5E1", VA = "0x225C4E0")]
	public void PlaySE_Debug(string name)
	{
	}

	// Token: 0x06003999 RID: 14745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600301D")]
	[Address(RVA = "0x225C580", Offset = "0x225C681", VA = "0x225C580")]
	public void PlayBGM_Debug(string name)
	{
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600301E")]
	[Address(RVA = "0x225C640", Offset = "0x225C741", VA = "0x225C640")]
	public SoundManager()
	{
	}

	// Token: 0x04007CBB RID: 31931
	[Token(Token = "0x40070CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioMixer MasterMixer;

	// Token: 0x04007CBC RID: 31932
	[Token(Token = "0x40070CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E1A0", Offset = "0x16E2A1")]
	private AudioMixerGroup[] <MixerVolumeGroups>k__BackingField;

	// Token: 0x04007CBD RID: 31933
	[Token(Token = "0x40070D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public AnimationCurve FadeInCurve;

	// Token: 0x04007CBE RID: 31934
	[Token(Token = "0x40070D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public AnimationCurve FadeOutCurve;

	// Token: 0x04007CBF RID: 31935
	[Token(Token = "0x40070D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<BGMController> BGMControllers;

	// Token: 0x04007CC0 RID: 31936
	[Token(Token = "0x40070D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private LinkedList<SEController> SE2DControllers;

	// Token: 0x04007CC1 RID: 31937
	[Token(Token = "0x40070D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LinkedList<VoiceController> Voice2DControllers;

	// Token: 0x04007CC2 RID: 31938
	[Token(Token = "0x40070D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LinkedList<SEController> SEPool;

	// Token: 0x04007CC3 RID: 31939
	[Token(Token = "0x40070D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform SEPoolTrans;

	// Token: 0x04007CC4 RID: 31940
	[Token(Token = "0x40070D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform PlayTrans;

	// Token: 0x04007CC5 RID: 31941
	[Token(Token = "0x40070D8")]
	private const int SE3DPoolMax = 30;

	// Token: 0x04007CC6 RID: 31942
	[Token(Token = "0x40070D9")]
	private const int BGMControllersMax = 3;

	// Token: 0x04007CC7 RID: 31943
	[Token(Token = "0x40070DA")]
	private const int SE2DControllersMax = 20;

	// Token: 0x04007CC8 RID: 31944
	[Token(Token = "0x40070DB")]
	private const int Voice2DControllersMax = 10;

	// Token: 0x04007CC9 RID: 31945
	[Token(Token = "0x40070DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private HashSet<SEController> PlaySE3DSet;

	// Token: 0x04007CCA RID: 31946
	[Token(Token = "0x40070DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E1D0", Offset = "0x16E2D1")]
	private AudioSource <MovieAudioSource>k__BackingField;

	// Token: 0x04007CCB RID: 31947
	[Token(Token = "0x40070DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ResourceManager<AudioClip> Resource_SE;

	// Token: 0x04007CCC RID: 31948
	[Token(Token = "0x40070DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ResourceManager<AudioClip> Resource_Voice;

	// Token: 0x04007CCD RID: 31949
	[Token(Token = "0x40070E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ResourceManager<AudioClip> Resource_BGM;

	// Token: 0x04007CCE RID: 31950
	[Token(Token = "0x40070E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private AudioSource OneShotAudioSource;

	// Token: 0x04007CCF RID: 31951
	[Token(Token = "0x40070E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E1E0", Offset = "0x16E2E1")]
	private BGMID <CurrentBGMID>k__BackingField;

	// Token: 0x04007CD0 RID: 31952
	[Token(Token = "0x40070E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16E1F0", Offset = "0x16E2F1")]
	private Dictionary<MixerVolumeGroup, ValueTuple<float, float>> VolumeRangeByMixerGroup;

	// Token: 0x04007CD1 RID: 31953
	[Token(Token = "0x40070E4")]
	private const string TimelineTmpName = "SoundManager_TimelineTest";

	// Token: 0x04007CD2 RID: 31954
	[Token(Token = "0x40070E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16E290", Offset = "0x16E391")]
	private Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>> EnvironmentAreaDictionay;

	// Token: 0x02000881 RID: 2177
	[Token(Token = "0x200125F")]
	private enum SoundState
	{
		// Token: 0x04007CD4 RID: 31956
		[Token(Token = "0x4019853")]
		Play,
		// Token: 0x04007CD5 RID: 31957
		[Token(Token = "0x4019854")]
		Done,
		// Token: 0x04007CD6 RID: 31958
		[Token(Token = "0x4019855")]
		Stop,
		// Token: 0x04007CD7 RID: 31959
		[Token(Token = "0x4019856")]
		FadeIn,
		// Token: 0x04007CD8 RID: 31960
		[Token(Token = "0x4019857")]
		FadeOut
	}

	// Token: 0x02000882 RID: 2178
	[Token(Token = "0x2001260")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158CF0", Offset = "0x158DF1")]
	private sealed class <>c__DisplayClass38_0
	{
		// Token: 0x0600399B RID: 14747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007463")]
		[Address(RVA = "0x2258D30", Offset = "0x2258E31", VA = "0x2258D30")]
		public <>c__DisplayClass38_0()
		{
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007464")]
		[Address(RVA = "0x225C970", Offset = "0x225CA71", VA = "0x225C970")]
		internal void <Entry>b__0(int backid, AudioClip clip)
		{
		}

		// Token: 0x04007CD9 RID: 31961
		[Token(Token = "0x4019858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<AudioClip> callback;
	}

	// Token: 0x02000883 RID: 2179
	[Token(Token = "0x2001261")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D00", Offset = "0x158E01")]
	private sealed class <>c__DisplayClass44_0
	{
		// Token: 0x0600399D RID: 14749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007465")]
		[Address(RVA = "0x2258EE0", Offset = "0x2258FE1", VA = "0x2258EE0")]
		public <>c__DisplayClass44_0()
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007466")]
		[Address(RVA = "0x225C9F0", Offset = "0x225CAF1", VA = "0x225C9F0")]
		internal void <PlayBGM_internal>b__0(AudioClip clip)
		{
		}

		// Token: 0x04007CDA RID: 31962
		[Token(Token = "0x4019859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundManager <>4__this;

		// Token: 0x04007CDB RID: 31963
		[Token(Token = "0x401985A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BGMID id;

		// Token: 0x04007CDC RID: 31964
		[Token(Token = "0x401985B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fadetime;

		// Token: 0x04007CDD RID: 31965
		[Token(Token = "0x401985C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int priority;
	}

	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2001262")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D10", Offset = "0x158E11")]
	private sealed class <>c__DisplayClass45_0
	{
		// Token: 0x0600399F RID: 14751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007467")]
		[Address(RVA = "0x2259090", Offset = "0x2259191", VA = "0x2259090")]
		public <>c__DisplayClass45_0()
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x6007468")]
		[Address(RVA = "0x225CC10", Offset = "0x225CD11", VA = "0x225CC10")]
		internal bool <PlaySE>b__0(SEController c)
		{
			return default(bool);
		}

		// Token: 0x04007CDE RID: 31966
		[Token(Token = "0x401985D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundID id;
	}

	// Token: 0x02000885 RID: 2181
	[Token(Token = "0x2001263")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D20", Offset = "0x158E21")]
	private sealed class <>c__DisplayClass46_0
	{
		// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007469")]
		[Address(RVA = "0x22591C0", Offset = "0x22592C1", VA = "0x22591C0")]
		public <>c__DisplayClass46_0()
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746A")]
		[Address(RVA = "0x225CCA0", Offset = "0x225CDA1", VA = "0x225CCA0")]
		internal void <PlayOneShot2D>b__0(int backid, AudioClip clip)
		{
		}

		// Token: 0x04007CDF RID: 31967
		[Token(Token = "0x401985E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundID id;

		// Token: 0x04007CE0 RID: 31968
		[Token(Token = "0x401985F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundManager <>4__this;
	}

	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2001264")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D30", Offset = "0x158E31")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x060039A3 RID: 14755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746B")]
		[Address(RVA = "0x2259340", Offset = "0x2259441", VA = "0x2259340")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x600746C")]
		[Address(RVA = "0x225CD90", Offset = "0x225CE91", VA = "0x225CD90")]
		internal bool <PlayVoice>b__0(VoiceController c)
		{
			return default(bool);
		}

		// Token: 0x04007CE1 RID: 31969
		[Token(Token = "0x4019860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundID id;
	}

	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2001265")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D40", Offset = "0x158E41")]
	private sealed class <>c__DisplayClass51_0
	{
		// Token: 0x060039A5 RID: 14757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746D")]
		[Address(RVA = "0x2259FD0", Offset = "0x225A0D1", VA = "0x2259FD0")]
		public <>c__DisplayClass51_0()
		{
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x600746E")]
		[Address(RVA = "0x225CE20", Offset = "0x225CF21", VA = "0x225CE20")]
		internal bool <PlaySE3D_internal>b__0(SEController s)
		{
			return default(bool);
		}

		// Token: 0x04007CE2 RID: 31970
		[Token(Token = "0x4019861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundID id;
	}

	// Token: 0x02000888 RID: 2184
	[Token(Token = "0x2001266")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D50", Offset = "0x158E51")]
	private sealed class <>c__DisplayClass57_0
	{
		// Token: 0x060039A7 RID: 14759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746F")]
		[Address(RVA = "0x225ABF0", Offset = "0x225ACF1", VA = "0x225ABF0")]
		public <>c__DisplayClass57_0()
		{
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x6007470")]
		[Address(RVA = "0x225CEE0", Offset = "0x225CFE1", VA = "0x225CEE0")]
		internal bool <StopSound>b__0(SEController c)
		{
			return default(bool);
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x6007471")]
		[Address(RVA = "0x225CFA0", Offset = "0x225D0A1", VA = "0x225CFA0")]
		internal bool <StopSound>b__1(SEController c)
		{
			return default(bool);
		}

		// Token: 0x04007CE3 RID: 31971
		[Token(Token = "0x4019862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundID soundID;

		// Token: 0x04007CE4 RID: 31972
		[Token(Token = "0x4019863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<SEController, bool> <>9__0;

		// Token: 0x04007CE5 RID: 31973
		[Token(Token = "0x4019864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<SEController, bool> <>9__1;
	}

	// Token: 0x02000889 RID: 2185
	[Token(Token = "0x2001267")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D60", Offset = "0x158E61")]
	private sealed class <>c__DisplayClass58_0
	{
		// Token: 0x060039AA RID: 14762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007472")]
		[Address(RVA = "0x225AF20", Offset = "0x225B021", VA = "0x225AF20")]
		public <>c__DisplayClass58_0()
		{
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x6007473")]
		[Address(RVA = "0x225D060", Offset = "0x225D161", VA = "0x225D060")]
		internal bool <StopVoice>b__0(VoiceController c)
		{
			return default(bool);
		}

		// Token: 0x04007CE6 RID: 31974
		[Token(Token = "0x4019865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundID soundID;

		// Token: 0x04007CE7 RID: 31975
		[Token(Token = "0x4019866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<VoiceController, bool> <>9__0;
	}
}

# Destination Board

シンプルな行先掲示板アプリです。



# コンセプトと開発ポリシー

日本企業にありがちな情報を、最低限表示できる、めちゃめちゃ簡単な行先掲示板です。（なのでドキュメントなども基本的に日本語ベースです）

タブレットなんかで職場でちょろっと行先をデジタルサイネージ的に見せられたらいいなと。

動作前提としては、非管理者のローカルユーザで常時起動しておくサイネージマシンで使われることを想定してます。

需要あるかわからないですが、自分がちょうど欲しかったので作り始めました。ホワイトボードでやってると手が汚れたり、面倒なんですよね。

開発要望は当面受け付けていません。（趣味プロジェクトだし、まずは安定板出すまでは）

TODO: 将来的にGitHub Projectにて受け付けたい。



# ライセンス

MITライセンスです。



# 機能の紹介

実装前機能は「TODO: 」で表示されます。



## 画面レイアウト

TODO: 実装と同時にスクリーンショットを追加



## 組織情報の表示

- TODO: 利用する組織の情報を表示することができます。

- TODO: 組織によってフロアにいるチームが疎らだと思ったので一部はオプションです。

- TODO: 表示する情報は[組織と人の設定](#組織と人の設定)から編集できます。

  

## 組織に所属する人のリスト表示

- TODO: 任意の組織、人の名前表示ができます。

- TODO: 最小単位の組織内では任意の順番で表示ができます。

- TODO: 組織内での責任者は下線表示で表示できます。

- TODO: 表示する情報は[組織と人の設定](#組織と人の設定)から編集できます。

- TODO: 名前を押下している間だけか表示モードの時だけ、会社支給の携帯電話の内線番号を表示することができます。

  

## 現在時刻と在席グラフの表示

- TODO: 現在の時刻を表示します。

- TODO: 個人名の背景として当日の在籍実績と戻り予定がグラフで表示される

  

## 勤務ステータスの入力・表示

- TODO: 当日の出退勤ステータスを入力・表示することができます。

- TODO: 出勤している場合は緑、未出勤または退勤した場合は赤のドットで表示します。

- TODO: 以下の場合、フレックス出勤の表示をします。

  - TODO: 設定した勤務時間の開始時刻から30分以上前に出勤した場合
  - TODO: 設定した勤務時間の開始時刻から30分以上後に出勤された場合
  - TODO: 閾値は設定で変更できます。

- TODO: 以下の場合、フレックス退勤の表示をします。

  - TODO: 設定した勤務時間の終了時刻より前に退勤された場合

  

## 検温結果の入力

- TODO: コロナウィルス感染拡大を受けて毎日の検温結果を出勤時に記録できます。

- TODO: 体温表示、体温非表示（検温有無のみ）の表示モードが選べます。

  

## 行先情報の入力・表示・通知

- TODO: 出勤後に離席する際、行先を一覧から選択し、その情報を保持して表示することができます。

- TODO: 行先情報は以下から選択します。
  - TODO: 事業所内の場所（エリア、建物、階、部屋、食堂）
  - TODO: 出張（他事業所、社外）
  - TODO: その他（食事、トイレ、たばこなど）

- TODO: 行先は[行先の設定](#行先の設定)から任意に増やすことができます。

- TODO: 行先は予め設定されたショートカットから選ぶこともできます。

- TODO: 行先はよく使われる場所から選ぶこともできます。

- TODO: 離席理由をリストから選ぶことができます。（オプション）

  - 会議、作業、試験、休憩（食事、トイレ、たばこなど）、その他

- TODO: 離席理由は[離席理由の設定](#離席理由の設定)から任意に増やすことができます。

- TODO: 予定表アプリ（O365など）からの取得ができるようにしたいです。

  

## 復席予定時間の入力・表示

- TODO: 離席先から戻る時間を30分単位で選択して入力・表示することができます。

- TODO: 選択できる時間は現在よりも後の時間から設定された最大値の間です。

- TODO: 現在時刻から復席時間までの残り時間を表示します。

  

## 残業時間の入力・表示

- TODO: 本日の申請済残業時間の表示

  

## 離席情報のクリア

- TODO: 席に戻ったときに離席情報をクリアして在席状態にできます。

  

## 翌日以降の予定表示

- TODO: 退勤時に翌日以降の行先設定ができます。翌日以降の予定は以下から選択・入力します。

  - TODO: 翌日のフレックス出勤予定時刻

  - TODO: 翌日休暇

  - TODO: 翌日出張が直行・直帰

  - TODO: 翌日出張＋戻り予定時間

  - TODO: 長期出張の終了日

  - TODO: 長期休みの終了日

  - TODO: 期間未確定の休職
  
    


## サイネージ領域でのPDF表示

- TODO: サイネージ領域の表示・非表示を選べます。

- TODO: サイネージエリアから表示するPDFファイルをファイルエクスプローラを使って選択できます。

- TODO: ファイルを選択したらサイネージ領域に任意のPDFを表示できます。

- TODO: 前回表示したPDFのフォルダと、ファイルを記憶します。

- TODO: PDFを閉じたら、これまでに開いたPDFがリスト表示されます。

- TODO: 任意のPDFをリストから削除することができます。

- TODO: 設定時間でファイルをループ表示できます

  

## 各種動作設定

- TODO: アプリの起動中、画面をスリープさせない設定を選べます。（Default: Enable）

- TODO: アプリの起動時、アプリを全画面表示にするか選べます。（Default: Enable）
  
- TODO: F11でいつでも全画面表示とウィンドウ表示をトグルで切り替えが可能です。
  
- TODO: 退勤ルールなどに合わせて戻り予定時間の最大値を設定できます。（Default: 22:00）

- TODO: 勤務時間の設定ができます。（Default: 9:00-17:00）

- TODO: フレックス出勤の閾値が分で設定できます。（Default: 30）

- TODO: 以下の組織名称を表示をするか選べます。（Default: Disenable）

  - TODO: 会社名、本部、部
  - TODO: 課、係（チーム）は必ず表示されます。
  - TODO: 上記に限らず、直接紐づく人が表示対象の場合は必ず表示されます。

- TODO: ステータス変更時にメール通知をするか選べるようにしたいです。
  - TODO: 送付先メールアドレス
  
    - TODO: Teamsなどの掲示板に連携することを想定しています。
  
  - TODO: メールフォーマット
  
    - TODO: Botなどで受け取った時に整理できるように一定のフォーマットで送ります。
    - TODO: 内容は部、課、チームのヘッダと、各人のステータス、変化時刻などです。
  
  - TODO: 送付タイミング
  
    - TODO: 行先情報が設定されたときに送ります。
  
    - TODO: 離席情報がクリアされたときに送ります。
  
      

## 組織と人の設定

- TODO: 組織情報は階層数に依存しない構造です。

- TODO: 以下のリストのメンテナンスができます。

  - TODO: 組織
    - TODO: 会社名（オプション）、本部（オプション）、部の表示（オプション）
    - TODO: 課の表示、係（チーム）の表示
  - TODO: 人
  - TODO: 所属する組織、名前、内線番号、表示有無

- TODO: リストはそれぞれjsonで入出力できます。

- TODO: LDAPによる組織情報の取り込みに対応する

  

## 行先リスト設定

- TODO: 行先リストに表示する情報を設定することができます。




## その他の便利機能

- TODO: 携帯内線番号に掛ける際のヘルプを表示できるようにしたいです。
- TODO: 休憩時間を時計の文字盤の色で示したいです。（24時間時計にしないと無理？）
- TODO: 時間を設定した、その時間になったらアラームを鳴らせるようにしたいです。
- TODO: 行動履歴を、指定した人・期間から出力できるようにしたいです。



# リリースノート

ナンバリングポリシーとしては[セマンティックバージョニング2.0.0](https://semver.org/lang/ja/)を採用しています。

メジャー.マイナー.パッチ 

アルファ版は開発途中ビルド、ベータはリリース候補版として扱います。

TODO: CIとCDを組んだらステータスバッジを入れる

## 最新の安定板

- なし

## ベータ版

- 0.0.0（XXXX-XX-XX）



# 開発マイルストンとリリースプラン

今後の開発マイルストンは以下の通りですが、予告なく変更する場合があります。（というかほとんどです）

- XXXX年XX月　1.0.0　初回リリース
- XXXX年XX月　X.0.0　XXX機能追加
- XXXX年XX月　X.0.0　XXX機能追加



# 開発プロセス

- ブランチ戦略
  - 少し面倒だけどgit-flowを採用
- 機能開発はdevelopからfeature/*ブランチを作成
  - 対象機能リリース後はfeatureブランチ削除
- main, developブランチはPR必須の保護をかける
- リリースQAはrelease/X.X.Xブランチを作成
  - 対象機能リリース後はタグを打ってreleaseブランチ削除
- ブランチ構成
  - main：リリース済みのブランチ
  - develop：テスト用のブランチ
  - feature
    - doc：ドキュメント作成用のブランチ
    - ui：ユーザーインターフェース設計用のブランチ
  

# 開発環境

以下の環境で開発・動作確認しています。

TODO: 今後、自動UIテストまでCIで組んでいきたいです。

- Documentation

  - [Visual Studio Code](https://azure.microsoft.com/ja-jp/products/visual-studio-code/)
  - [INKSCAPE](https://inkscape.org/)

- UI Design

  - [Figma](https://www.figma.com/)
  - [Figma Windows UI](https://www.figma.com/community/file/989931624019688277)
  
- Development Environment

  - [Windows 10 Pro 21H2](https://docs.microsoft.com/ja-jp/windows/release-health/status-windows-10-21h2)
  - [Windows 11 Pro 21H2](https://docs.microsoft.com/ja-jp/windows/release-health/windows11-release-information)
  - [Visual Studio Community 2022 Version 17](https://visualstudio.microsoft.com/)
    - インストール時の構成は[こちら](VisualStudio2022InstallConfig.vsconfig)

- Frameworks and Data

  - WPF: Windows Presentation Foundation
  - [.NET 6.0 LTS](https://dotnet.microsoft.com/download/dotnet/6.0)
  - [Microsoft.Data.Sqlite.Core](https://www.nuget.org/packages/Microsoft.Data.Sqlite.Core/6.0.0)

- CI & CD

  - TODO: [Axo Cover](https://marketplace.visualstudio.com/items?itemName=axodox1.AxoCover), MSTest
  - TODO: GitHub Actions
  - TODO: [App Center](https://appcenter.ms)

- Packaging & Release

  - TODO: GitHub Release

  - TODO: MSIX

    

# アプリケーションアーキテクチャ

- Windows 10/11向けのデスクトップアプリ

  - [Any CPUで各CPUアーキテクチャに対応](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/compiler-options/output#platformtarget)

- タッチ操作に対応

  - 職場などでの常設可能なWindowsマシンまたはタブレットでの使用を想定

- アプリ配信はGitHub ReleaseからのMSIXのZipダウンロードしてサイドローディング

  - Windows Storeは制限されていることが多い
  - TODO: 配信サイトをAzure Websiteで配信したい

- データは[SQLite](https://ja.wikipedia.org/wiki/SQLite)ファイルを独自拡張子でProgramDataに保存

  - オフラインの共用マシンの利用を想定
  - 拡張子は他アプリと混ざらないように独自設定（.destborad）

  - Windowsの流儀に従う
    - Windows File System Namespace Usage Guidelinesを参照（現在非公開？）



以上

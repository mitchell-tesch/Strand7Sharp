# St7SetLicenceOptions

Sets how the API responds when it suffers a loss of licence.

long St7SetLicenceOptions(long Mode, long MaxRetry, long RetryPause)

Input Parameters

Mode

lmMessageBox – display a dialog with Retry and Abort buttons. The API will automatically retry every
RetryPause seconds.
lmWaitRetry – silently attempt to obtain a licence MaxRetry times every RetryPause seconds. If the
licence is not obtained, an error code is returned.
lmAbort – returns a licence related error code without retrying.

MaxRetry

Number of times to automatically retry to obtain a licence. This option applies to lmWaitRetry mode.

RetryPause

Duration in seconds to wait between automatic retry attempts. This option applies to lmMessageBox
and lmWaitRetry modes.

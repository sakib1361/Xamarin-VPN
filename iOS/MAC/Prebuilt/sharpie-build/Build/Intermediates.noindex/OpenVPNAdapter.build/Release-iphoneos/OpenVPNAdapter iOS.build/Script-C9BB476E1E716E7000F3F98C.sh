#!/bin/sh
TAGS="TODO:|FIXME:|\?\?\?|\!\!\!"
ERRORTAG="ERROR:"
find "${SRCROOT}/Sources/OpenVPNAdapter" \( -name "*.h" -or -name "*.mm" -or -name "*.m" -or -name "*.swift" \) ! -path "*/Vendors/*" -print0 | xargs -0 egrep --with-filename --line-number --only-matching "($TAGS).*\$|($ERRORTAG).*\$" | perl -p -e "s/($TAGS)/ warning: \$1/" | perl -p -e "s/($ERRORTAG)/ error: \$1/"

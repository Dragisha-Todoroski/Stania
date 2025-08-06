import { ButtonPropsType } from "@/types/ui-props";

export default function Button({
  type,
  children,
  ariaLabel,
  className,
  ariaDisabled = false,
}: ButtonPropsType) {
  return (
    <button className={` ${className}`} aria-disabled={ariaDisabled} type={type} aria-label={ariaLabel}>
      {children}
    </button>
  );
}

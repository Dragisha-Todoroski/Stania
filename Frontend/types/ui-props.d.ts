export type ButtonPropsType = {
    type: 'button' | 'submit' | 'reset'
    className?: string;
    ariaLabel?: string;
    ariaDisabled: boolean;
    children?: React.ReactNode;
    onClick: () => void;
}
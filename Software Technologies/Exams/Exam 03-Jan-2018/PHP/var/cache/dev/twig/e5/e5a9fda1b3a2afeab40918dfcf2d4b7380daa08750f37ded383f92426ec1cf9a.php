<?php

/* :project:index.html.twig */
class __TwigTemplate_cf27bdab4def7a1505caf8086f50ac9f805b5803ef626d6de7b66e5a94f31449 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":project:index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_effab1f33be3d703f6350674c6c535c9c4e0e8b35209fbcff62c765350235e9e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_effab1f33be3d703f6350674c6c535c9c4e0e8b35209fbcff62c765350235e9e->enter($__internal_effab1f33be3d703f6350674c6c535c9c4e0e8b35209fbcff62c765350235e9e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:index.html.twig"));

        $__internal_9b913f97a4324f0c073a852982123cf10dee8667ee8fc006590e2d0afb33ff98 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9b913f97a4324f0c073a852982123cf10dee8667ee8fc006590e2d0afb33ff98->enter($__internal_9b913f97a4324f0c073a852982123cf10dee8667ee8fc006590e2d0afb33ff98_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_effab1f33be3d703f6350674c6c535c9c4e0e8b35209fbcff62c765350235e9e->leave($__internal_effab1f33be3d703f6350674c6c535c9c4e0e8b35209fbcff62c765350235e9e_prof);

        
        $__internal_9b913f97a4324f0c073a852982123cf10dee8667ee8fc006590e2d0afb33ff98->leave($__internal_9b913f97a4324f0c073a852982123cf10dee8667ee8fc006590e2d0afb33ff98_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_0344ec6a9eec189f96b61944b06e58ac3e088aaa7e8e4527fab47ca721d22afa = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0344ec6a9eec189f96b61944b06e58ac3e088aaa7e8e4527fab47ca721d22afa->enter($__internal_0344ec6a9eec189f96b61944b06e58ac3e088aaa7e8e4527fab47ca721d22afa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_1108d76b586cf7811618ed62d03cd65ed69a190a151ca4a5e95b7117e9b008f4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1108d76b586cf7811618ed62d03cd65ed69a190a151ca4a5e95b7117e9b008f4->enter($__internal_1108d76b586cf7811618ed62d03cd65ed69a190a151ca4a5e95b7117e9b008f4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <div class=\"button-holder\">
        <a type=\"button\" href=\"/create\" class=\"log-button\">Create New Project</a>
    </div>
    <div class=\"content\">
        <div class=\"header\">
            <div class=\"project-label\">Project</div>
            <div class=\"budget-label\">Budget</div>
            <div class=\"actions-label\">Actions</div>
        </div>
        <div class=\"main\">
            ";
        // line 15
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["projects"] ?? $this->getContext($context, "projects")));
        foreach ($context['_seq'] as $context["_key"] => $context["project"]) {
            // line 16
            echo "                <div class=\"project\">
                    <div class=\"project-title\">
                        ";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute($context["project"], "title", array()), "html", null, true);
            echo "
                    </div>
                    <div class=\"project-budget\">
                        ";
            // line 21
            echo twig_escape_filter($this->env, $this->getAttribute($context["project"], "budget", array()), "html", null, true);
            echo "
                    </div>
                    <div class=\"project-actions\">
                        <a type=\"button\" href=\"";
            // line 24
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("edit", array("id" => $this->getAttribute($context["project"], "id", array()))), "html", null, true);
            echo "\" class=\"edit-button\">Edit</a>
                        <a type=\"button\" href=\"";
            // line 25
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("delete", array("id" => $this->getAttribute($context["project"], "id", array()))), "html", null, true);
            echo "\" class=\"delete-button\">Delete</a>
                    </div>
                </div>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['project'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 29
        echo "        </div>
    </div>
</div>
";
        
        $__internal_1108d76b586cf7811618ed62d03cd65ed69a190a151ca4a5e95b7117e9b008f4->leave($__internal_1108d76b586cf7811618ed62d03cd65ed69a190a151ca4a5e95b7117e9b008f4_prof);

        
        $__internal_0344ec6a9eec189f96b61944b06e58ac3e088aaa7e8e4527fab47ca721d22afa->leave($__internal_0344ec6a9eec189f96b61944b06e58ac3e088aaa7e8e4527fab47ca721d22afa_prof);

    }

    public function getTemplateName()
    {
        return ":project:index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  96 => 29,  86 => 25,  82 => 24,  76 => 21,  70 => 18,  66 => 16,  62 => 15,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <div class=\"button-holder\">
        <a type=\"button\" href=\"/create\" class=\"log-button\">Create New Project</a>
    </div>
    <div class=\"content\">
        <div class=\"header\">
            <div class=\"project-label\">Project</div>
            <div class=\"budget-label\">Budget</div>
            <div class=\"actions-label\">Actions</div>
        </div>
        <div class=\"main\">
            {% for project in projects %}
                <div class=\"project\">
                    <div class=\"project-title\">
                        {{ project.title }}
                    </div>
                    <div class=\"project-budget\">
                        {{ project.budget }}
                    </div>
                    <div class=\"project-actions\">
                        <a type=\"button\" href=\"{{ path('edit', {id: project.id}) }}\" class=\"edit-button\">Edit</a>
                        <a type=\"button\" href=\"{{ path('delete', {id: project.id}) }}\" class=\"delete-button\">Delete</a>
                    </div>
                </div>
            {% endfor %}
        </div>
    </div>
</div>
{% endblock %}", ":project:index.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\app/Resources\\views/project/index.html.twig");
    }
}
